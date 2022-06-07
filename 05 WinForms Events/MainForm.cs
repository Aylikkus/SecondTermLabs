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
    public struct DateEvent
    {
        DateTime _eventDay;
        string _name;
        string _description;

        public DateEvent(DateTime eventDay,
            string name, string description)
        {
            _eventDay = eventDay.Date;
            _name = name;
            _description = description;
        }

        public DateTime EventDay
        {
            get { return _eventDay; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }
    }

    

    public partial class MainForm : Form
    {
        List<DateEvent> dateEvents = new List<DateEvent>();
        List<int> apcmgEvents  = new List<int>();

        // Обновление ближайших событий
        public void UpdateApcmgEvents(int span = 7)
        {
            apcmgEvents.Clear();
            int index = 0;
            foreach (var dateEvent in dateEvents)
            {
                if (dateEvent.EventDay - DateTime.Today 
                    <= TimeSpan.FromDays(span))
                {
                    apcmgEvents.Add(index);
                }
                index++;
            }
        }

        // Обновление элементов в GroupBox, 
        // показывающем ближайшие события
        public void UpdateEvGrpBox(int offset = 0)
        {
            evGrpBox.Controls.Clear();
            foreach (var index in apcmgEvents)
            {
                offset += 25;
                if (offset >= evGrpBox.Size.Height)
                    break;

                Label sideLabel = new Label();
                sideLabel.Text = $"{dateEvents[index].Name} на " +
                    $"{dateEvents[index].EventDay.ToString("d")}";
                sideLabel.AutoEllipsis = true;
                sideLabel.Width = evGrpBox.Width - 10;
                sideLabel.Location = new Point(3, offset);
                evGrpBox.Controls.Add(sideLabel);
            }
        }

        // Обновление ListBox, необходимого для 
        // отображения событий на текущую дату
        public void UpdateListBox()
        {
            evListBox.Items.Clear();
            int index = 1;
            foreach (var value in dateEvents)
            {
                if (value.EventDay.Date == dateTimePicker.Value.Date)
                {
                        evListBox.Items.Add($"{index} {value.Name}");
                }
                index++;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            UpdateApcmgEvents();
            UpdateListBox();
            UpdateEvGrpBox();

            dayLabel.Text = dateTimePicker.Value.ToString("D");
        }

        // Методы, связанные с событиями элемента DateTimePicker
        private void DateTimePicker_CloseUp(object sender, EventArgs e)
        {
            UpdateEvGrpBox();
        }

        private void DateTimePicker_DropDown(object sender, EventArgs e)
        {
            UpdateEvGrpBox(140);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox();
            infoPanel.Visible = false;
            dayLabel.Text = dateTimePicker.Value.ToString("D");
        }

        private void DateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                AddEvForm addEvForm = new AddEvForm(dateTimePicker.Value,
                    ref dateEvents);
                addEvForm.checkBtn.Click += ChildFormBtn_Click;
                addEvForm.Show();
            }
        }

        private void DateTimePicker_MouseEnter(object sender, EventArgs e)
        {
            dateTimePicker.Font = new Font("Microsoft Sans Serif", 8.25F, 
                FontStyle.Bold, GraphicsUnit.Point, 204);
        }
        private void DateTimePicker_MouseLeave(object sender, EventArgs e)
        {
            dateTimePicker.Font = new Font("Microsoft Sans Serif", 8.25F,
                FontStyle.Regular, GraphicsUnit.Point, 204);
        }

        private void DateTimePicker_SizeChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Width < 160)
                dateTimePicker.Format = DateTimePickerFormat.Short;
            else
                dateTimePicker.Format = DateTimePickerFormat.Long;
        }

        // Методы, связанные с кнопками добавления и отображения событий
        private void listEventsBtn_Click(object sender, EventArgs e)
        {
            ListEvForm listEvForm = new ListEvForm(ref dateEvents);
            listEvForm.rmvBtn.Click += ChildFormBtn_Click;
            listEvForm.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEvForm addEvForm = new AddEvForm(dateTimePicker.Value,
                ref dateEvents);
            addEvForm.checkBtn.Click += ChildFormBtn_Click;
            addEvForm.Show();
        }

        private void ChildFormBtn_Click(object sender, EventArgs e)
        {
            UpdateApcmgEvents();
            UpdateEvGrpBox();
            UpdateListBox();
        }

        // Происходит при изменении индекса в ListBox
        // отображающем события на текущую дату
        private void EvListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoPanel.Visible = true;
            string strIndex = "";
            foreach (var value in evListBox.SelectedItem.ToString())
            {
                if (value == ' ')
                    break;
                strIndex += value;
            }

            evNameLbl.Text = dateEvents[int.Parse(strIndex) - 1].Name;
            evDescLbl.Text = dateEvents[int.Parse(strIndex) - 1].Description;
        }
    }
}
