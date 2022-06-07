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
    public partial class AddEvForm : Form
    {
        List<DateEvent> dateEvents;
        DateTime dateTime;

        public AddEvForm(DateTime dateTime,
            ref List<DateEvent> dateEvents)
        {
            InitializeComponent();

            this.dateEvents = dateEvents;
            this.dateTime = dateTime;
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Имя...")
                nameTextBox.Text = "";
        }

        private void DescTextBox_Enter(object sender, EventArgs e)
        {
            if (descTextBox.Text == "Описание...")
                descTextBox.Text = "";
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            dateEvents.Add(new DateEvent(dateTime, 
                nameTextBox.Text, descTextBox.Text));
        }
    }
}
