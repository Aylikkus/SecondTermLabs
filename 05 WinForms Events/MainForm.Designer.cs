namespace WinFormsEvents
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.evGrpBox = new System.Windows.Forms.GroupBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.listEventsBtn = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.evDescLbl = new System.Windows.Forms.Label();
            this.evNameLbl = new System.Windows.Forms.Label();
            this.evListBox = new System.Windows.Forms.ListBox();
            this.dayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker.Location = new System.Drawing.Point(2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2022, 3, 25, 0, 0, 0, 0);
            this.dateTimePicker.CloseUp += new System.EventHandler(this.DateTimePicker_CloseUp);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.dateTimePicker.DropDown += new System.EventHandler(this.DateTimePicker_DropDown);
            this.dateTimePicker.SizeChanged += new System.EventHandler(this.DateTimePicker_SizeChanged);
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateTimePicker_KeyDown);
            this.dateTimePicker.MouseEnter += new System.EventHandler(this.DateTimePicker_MouseEnter);
            this.dateTimePicker.MouseLeave += new System.EventHandler(this.DateTimePicker_MouseLeave);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer.Panel1.Controls.Add(this.evGrpBox);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePicker);
            this.splitContainer.Panel1.Controls.Add(this.btnPanel);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel1MinSize = 150;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.infoPanel);
            this.splitContainer.Panel2.Controls.Add(this.evListBox);
            this.splitContainer.Panel2.Controls.Add(this.dayLabel);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel2MinSize = 500;
            this.splitContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 196;
            this.splitContainer.TabIndex = 4;
            // 
            // evGrpBox
            // 
            this.evGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evGrpBox.Location = new System.Drawing.Point(2, 22);
            this.evGrpBox.Name = "evGrpBox";
            this.evGrpBox.Padding = new System.Windows.Forms.Padding(2);
            this.evGrpBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.evGrpBox.Size = new System.Drawing.Size(190, 376);
            this.evGrpBox.TabIndex = 2;
            this.evGrpBox.TabStop = false;
            this.evGrpBox.Text = "Ближайшие события";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.addBtn);
            this.btnPanel.Controls.Add(this.listEventsBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(2, 398);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(190, 48);
            this.btnPanel.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(190, 24);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить событие";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // listEventsBtn
            // 
            this.listEventsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listEventsBtn.Location = new System.Drawing.Point(0, 24);
            this.listEventsBtn.Name = "listEventsBtn";
            this.listEventsBtn.Size = new System.Drawing.Size(190, 24);
            this.listEventsBtn.TabIndex = 1;
            this.listEventsBtn.Text = "Показать все события";
            this.listEventsBtn.UseVisualStyleBackColor = true;
            this.listEventsBtn.Click += new System.EventHandler(this.listEventsBtn_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.evDescLbl);
            this.infoPanel.Controls.Add(this.evNameLbl);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(122, 44);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(474, 402);
            this.infoPanel.TabIndex = 2;
            this.infoPanel.Visible = false;
            // 
            // evDescLbl
            // 
            this.evDescLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evDescLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evDescLbl.Location = new System.Drawing.Point(0, 23);
            this.evDescLbl.Name = "evDescLbl";
            this.evDescLbl.Padding = new System.Windows.Forms.Padding(5);
            this.evDescLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.evDescLbl.Size = new System.Drawing.Size(474, 379);
            this.evDescLbl.TabIndex = 1;
            this.evDescLbl.Text = "Event Description Label";
            // 
            // evNameLbl
            // 
            this.evNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.evNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evNameLbl.Location = new System.Drawing.Point(0, 0);
            this.evNameLbl.Name = "evNameLbl";
            this.evNameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.evNameLbl.Size = new System.Drawing.Size(474, 23);
            this.evNameLbl.TabIndex = 0;
            this.evNameLbl.Text = "Event Name Label";
            this.evNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evListBox
            // 
            this.evListBox.BackColor = System.Drawing.SystemColors.Window;
            this.evListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.evListBox.FormattingEnabled = true;
            this.evListBox.Location = new System.Drawing.Point(2, 44);
            this.evListBox.Name = "evListBox";
            this.evListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.evListBox.Size = new System.Drawing.Size(120, 402);
            this.evListBox.TabIndex = 1;
            this.evListBox.SelectedIndexChanged += new System.EventHandler(this.EvListBox_SelectedIndexChanged);
            // 
            // dayLabel
            // 
            this.dayLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.Location = new System.Drawing.Point(2, 2);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Padding = new System.Windows.Forms.Padding(3);
            this.dayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dayLabel.Size = new System.Drawing.Size(594, 42);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "Day Label";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "Календарь";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.ListBox evListBox;
        private System.Windows.Forms.Button listEventsBtn;
        private System.Windows.Forms.GroupBox evGrpBox;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label evDescLbl;
        private System.Windows.Forms.Label evNameLbl;
    }
}

