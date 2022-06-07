using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase
{
    public partial class MainForm : Form
    {
        OleDbConnection connection;
        DataTable soundCardsDT, shopsDT, assortmentDT;
        Func<DataTable> focusedDataTable;
        int index;

        private static string GetConnectionString(string path)
        {
            return "Provider = MICROSOFT.ACE.OLEDB.12.0;" +
                  $"Data Source = '{path}';";
        }

        private void UpdateFromDataBase(DataTable dt)
        {
            dt.Clear();

            OleDbCommand command = new OleDbCommand("SELECT * FROM " +
                $"`{dt.TableName}`", connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(dt);
        }

        public MainForm()
        {
            InitializeComponent();

            soundCardsDT = new DataTable("Звуковые карты");
            assortmentDT = new DataTable("Ассортимент");
            shopsDT      = new DataTable("Магазины");

            connection = new OleDbConnection(GetConnectionString(
                "C:\\Temp\\soundCards.accdb"));
            connection.Open();

            dataGridViewSoundCards.DataSource = soundCardsDT;
            dataGridViewAssortment.DataSource = assortmentDT;
            dataGridViewShops.DataSource      = shopsDT;

            UpdateFromDataBase(soundCardsDT);
            UpdateFromDataBase(assortmentDT);
            UpdateFromDataBase(shopsDT);

            dataGridViewSoundCards.Enter += dataGridViews_Enter;
            dataGridViewAssortment.Enter += dataGridViews_Enter;
            dataGridViewShops.Enter      += dataGridViews_Enter;

            dataGridViewSoundCards.Leave += dataGridViews_Leave;
            dataGridViewAssortment.Leave += dataGridViews_Leave;
            dataGridViewShops.Leave      += dataGridViews_Leave;

            dataGridViewSoundCards.RowEnter += dataGridViews_RowEnter;
            dataGridViewAssortment.RowEnter += dataGridViews_RowEnter;
            dataGridViewShops.RowEnter      += dataGridViews_RowEnter;
        }

        private void dataGridViews_Enter(object sender, EventArgs e)
        {
            ((DataGridView)sender).BackgroundColor = SystemColors.ControlDarkDark;
            focusedDataTable = () => (DataTable)((DataGridView)sender).DataSource;
        }

        private void dataGridViews_Leave(object sender, EventArgs e)
        {
            ((DataGridView)sender).BackgroundColor = SystemColors.AppWorkspace;
        }

        private void dataGridViews_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            PromptForm pf = new PromptForm(focusedDataTable(), 
                connection);
            pf.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            PromptForm pf = new PromptForm(focusedDataTable(), 
                connection, index);
            pf.Show();
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand delComm = new OleDbCommand("DELETE FROM " +
                $"`{focusedDataTable().TableName}` WHERE " +
                $"[{focusedDataTable().Columns[0].ColumnName}] " +
                $"= {focusedDataTable().Rows[index][0]}", connection);
                delComm.ExecuteNonQuery();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Нет элементов!");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                UpdateFromDataBase(focusedDataTable());
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateFromDataBase(soundCardsDT);
            UpdateFromDataBase(shopsDT);
            UpdateFromDataBase(assortmentDT);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
