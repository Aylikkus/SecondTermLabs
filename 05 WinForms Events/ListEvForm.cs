using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEvents
{
    public partial class ListEvForm : Form
    {
        List<DateEvent> dateEvents;

        public void UpdateListBox()
        {
            evListBox.Items.Clear();
            int index = 1;
            foreach (var value in dateEvents)
            {
                evListBox.Items.Add($"{index}\t {value.Name}\t {value.Description}");
                index++;
            }
        }

        public ListEvForm(ref List<DateEvent> dateEvents)
        {
            InitializeComponent();

            this.dateEvents = dateEvents;
            UpdateListBox();
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                dateEvents.RemoveAt(evListBox.SelectedIndex);
                UpdateListBox();
            }
            catch
            {
                MessageBox.Show("Выберите событие или создайте новое");
            }
        }
    }
}
