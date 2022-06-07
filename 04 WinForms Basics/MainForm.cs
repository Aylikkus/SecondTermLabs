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
    public struct Note
    {
        string _name;
        string _description;

        public Note(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name 
        {
            get { return _name;  }
            set { _name = value; }
        }
        public string Description 
        { 
            get { return _description;  }
            set { _description = value; }
        }
    }

    public partial class MainForm : Form
    {
        private List<Note> notes = new List<Note>();

        public void AddNote(string name, string description)
        {
            notes.Add(new Note(name, description));
        }

        public void UpdateListBox()
        {
            ListBoxNotes.Items.Clear();
            foreach (var note in notes)
            {
                ListBoxNotes.Items.Add(note.Name);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void ListBoxNotes_Click(object sender, EventArgs e)
        {
            controlPanel.Visible = true;
            nameTextBox.Text = notes[ListBoxNotes.SelectedIndex].Name;
            deskTextBox.Text = notes[ListBoxNotes.SelectedIndex].Description;
        }

        private void AddNoteBtn_Click(object sender, EventArgs e)
        {
            AddNoteForm dialogForm = new AddNoteForm(this);
            dialogForm.Show();
        }

        private void RemoveNoteBtn_Click(object sender, EventArgs e)
        {
            notes.RemoveAt(ListBoxNotes.SelectedIndex);
            UpdateListBox();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string noteName = nameTextBox.Text;
            string noteDesk = deskTextBox.Text;

            Note note = new Note(noteName, noteDesk);
            notes[ListBoxNotes.SelectedIndex] = note;

            UpdateListBox();
        }
    }
}
