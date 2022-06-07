using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class PromptForm : Form
    {
        List<TextBox> textBoxes;
        OleDbConnection connection;
        DataTable dt;
        int? dbIndex;

        // Конструктор формы для добавления
        public PromptForm(DataTable dt,OleDbConnection connection)
        {
            InitializeComponent();

            textBoxes = new List<TextBox>();

            this.Text = "Добавление";

            this.dt = dt;
            this.connection = connection;

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                // Добавление надписей колонок из базы данных
                Label colName = new Label();
                colName.Location = new Point((i - 1) * 80, 0);
                colName.Size = new Size(80, 40);
                colName.Text = dt.Columns[i].ColumnName;
                Controls.Add(colName);

                // Добавление текстовых полей
                TextBox colTextBox = new TextBox();
                colTextBox.Location = new Point((i - 1) * 80, 40);
                colTextBox.Size = new Size(80, 60);
                textBoxes.Add(colTextBox);
                Controls.Add(colTextBox);
            }
        }

        // Если указывается индекс,
        // значит форма создаётся для редактирования
        public PromptForm(DataTable dt, OleDbConnection connection, int index)
        {
            InitializeComponent();

            textBoxes = new List<TextBox>();

            this.Text = "Редактирование";

            this.dt = dt;
            this.connection = connection;
            dbIndex = (int)dt.Rows[index][0];

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                // Добавление надписей колонок из базы данных
                Label colName = new Label();
                colName.Location = new Point((i - 1) * 80, 0);
                colName.Size = new Size(80, 40);
                colName.Text = dt.Columns[i].ColumnName;
                Controls.Add(colName);

                // Добавление текстовых полей
                TextBox colTextBox = new TextBox();
                colTextBox.Location = new Point((i - 1) * 80, 40);
                colTextBox.Size = new Size(80, 60);

                try
                {
                    colTextBox.Text = dt.Rows[index][i].ToString();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Нет элементов");
                    Controls.Clear();
                    return;
                }

                textBoxes.Add(colTextBox);
                Controls.Add(colTextBox);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            // Добавление
            if (dbIndex is null)
            {
                StringBuilder sb = new StringBuilder("INSERT INTO " +
                    $"`{dt.TableName}` (");
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    sb.Append($"`{dt.Columns[i].ColumnName}`,");
                }

                sb[sb.Length - 1] = ')';
                sb.Append($"VALUES (");
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    sb.Append($"'{textBoxes[i].Text}',");
                }
                sb[sb.Length - 1] = ')';

                OleDbCommand insComm = new OleDbCommand(sb.ToString(),
                    connection);
                try 
                { 
                    insComm.ExecuteNonQuery(); 
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Редактирование
            else
            {
                StringBuilder sb = new StringBuilder("UPDATE " +
                    $"`{dt.TableName}` SET ");
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    sb.Append($"[{dt.Columns[i].ColumnName}]=" +
                        $"'{textBoxes[i - 1].Text}',");
                }

                sb[sb.Length - 1] = ' ';
                sb.Append($"WHERE [{dt.Columns[0].ColumnName}] = {dbIndex}");

                OleDbCommand updComm = new OleDbCommand(sb.ToString(),
                    connection);
                try
                {
                    updComm.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
