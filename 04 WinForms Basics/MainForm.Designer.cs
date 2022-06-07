namespace WinForms
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
            this.ListBoxNotes = new System.Windows.Forms.ListBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.deskPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.deskTextBox = new System.Windows.Forms.TextBox();
            this.deskLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.AddNoteBtn = new System.Windows.Forms.Button();
            this.RemoveNoteBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.notesControlPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.deskPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.notesControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxNotes
            // 
            this.ListBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxNotes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxNotes.FormattingEnabled = true;
            this.ListBoxNotes.ItemHeight = 18;
            this.ListBoxNotes.Location = new System.Drawing.Point(0, 0);
            this.ListBoxNotes.Margin = new System.Windows.Forms.Padding(0);
            this.ListBoxNotes.Name = "ListBoxNotes";
            this.ListBoxNotes.Size = new System.Drawing.Size(200, 594);
            this.ListBoxNotes.TabIndex = 1;
            this.ListBoxNotes.Click += new System.EventHandler(this.ListBoxNotes_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(200, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(828, 50);
            this.infoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление заметками";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.deskPanel);
            this.controlPanel.Controls.Add(this.namePanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(200, 50);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.controlPanel.Size = new System.Drawing.Size(828, 544);
            this.controlPanel.TabIndex = 2;
            this.controlPanel.Visible = false;
            // 
            // deskPanel
            // 
            this.deskPanel.Controls.Add(this.SaveBtn);
            this.deskPanel.Controls.Add(this.deskTextBox);
            this.deskPanel.Controls.Add(this.deskLabel);
            this.deskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskPanel.Location = new System.Drawing.Point(12, 112);
            this.deskPanel.Name = "deskPanel";
            this.deskPanel.Padding = new System.Windows.Forms.Padding(3);
            this.deskPanel.Size = new System.Drawing.Size(804, 432);
            this.deskPanel.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveBtn.Location = new System.Drawing.Point(3, 406);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(798, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // deskTextBox
            // 
            this.deskTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deskTextBox.Location = new System.Drawing.Point(3, 23);
            this.deskTextBox.Multiline = true;
            this.deskTextBox.Name = "deskTextBox";
            this.deskTextBox.Size = new System.Drawing.Size(798, 406);
            this.deskTextBox.TabIndex = 2;
            // 
            // deskLabel
            // 
            this.deskLabel.AutoSize = true;
            this.deskLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deskLabel.Location = new System.Drawing.Point(3, 3);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Size = new System.Drawing.Size(83, 20);
            this.deskLabel.TabIndex = 1;
            this.deskLabel.Text = "Описание";
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePanel.Location = new System.Drawing.Point(12, 12);
            this.namePanel.Name = "namePanel";
            this.namePanel.Padding = new System.Windows.Forms.Padding(3);
            this.namePanel.Size = new System.Drawing.Size(804, 100);
            this.namePanel.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 23);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(798, 74);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Заметка";
            // 
            // AddNoteBtn
            // 
            this.AddNoteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddNoteBtn.Location = new System.Drawing.Point(0, 0);
            this.AddNoteBtn.Name = "AddNoteBtn";
            this.AddNoteBtn.Size = new System.Drawing.Size(100, 25);
            this.AddNoteBtn.TabIndex = 4;
            this.AddNoteBtn.Text = "Добавить";
            this.AddNoteBtn.UseVisualStyleBackColor = true;
            this.AddNoteBtn.Click += new System.EventHandler(this.AddNoteBtn_Click);
            // 
            // RemoveNoteBtn
            // 
            this.RemoveNoteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemoveNoteBtn.Location = new System.Drawing.Point(100, 0);
            this.RemoveNoteBtn.Name = "RemoveNoteBtn";
            this.RemoveNoteBtn.Size = new System.Drawing.Size(100, 25);
            this.RemoveNoteBtn.TabIndex = 5;
            this.RemoveNoteBtn.Text = "Удалить";
            this.RemoveNoteBtn.UseVisualStyleBackColor = true;
            this.RemoveNoteBtn.Click += new System.EventHandler(this.RemoveNoteBtn_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.notesControlPanel);
            this.sidePanel.Controls.Add(this.ListBoxNotes);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 594);
            this.sidePanel.TabIndex = 3;
            // 
            // notesControlPanel
            // 
            this.notesControlPanel.Controls.Add(this.RemoveNoteBtn);
            this.notesControlPanel.Controls.Add(this.AddNoteBtn);
            this.notesControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notesControlPanel.Location = new System.Drawing.Point(0, 569);
            this.notesControlPanel.Name = "notesControlPanel";
            this.notesControlPanel.Size = new System.Drawing.Size(200, 25);
            this.notesControlPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "MainForm";
            this.Text = "Заметки";
            this.infoPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.deskPanel.ResumeLayout(false);
            this.deskPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.notesControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxNotes;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button AddNoteBtn;
        private System.Windows.Forms.Button RemoveNoteBtn;
        private System.Windows.Forms.Panel notesControlPanel;
        private System.Windows.Forms.Panel deskPanel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label deskLabel;
        private System.Windows.Forms.TextBox deskTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}

