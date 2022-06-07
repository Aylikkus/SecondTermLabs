using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AddNoteForm : Form
    {
        public MainForm mainForm { get; set; }
        public AddNoteForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string noteName = nameBox.Text;
            string noteDesk = deskBox.Text;

            mainForm.AddNote(noteName, noteDesk);
            mainForm.UpdateListBox();
        }
    }
}
