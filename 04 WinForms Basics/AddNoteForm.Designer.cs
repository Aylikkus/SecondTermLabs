namespace WinForms
{
    partial class AddNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deskPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.deskBox = new System.Windows.Forms.TextBox();
            this.deskLabel = new System.Windows.Forms.Label();
            this.namePanel.SuspendLayout();
            this.deskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameBox);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Padding = new System.Windows.Forms.Padding(6);
            this.namePanel.Size = new System.Drawing.Size(558, 60);
            this.namePanel.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(6, 26);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(546, 28);
            this.nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(6, 6);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(95, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deskPanel
            // 
            this.deskPanel.Controls.Add(this.SaveBtn);
            this.deskPanel.Controls.Add(this.deskBox);
            this.deskPanel.Controls.Add(this.deskLabel);
            this.deskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskPanel.Location = new System.Drawing.Point(0, 60);
            this.deskPanel.Name = "deskPanel";
            this.deskPanel.Padding = new System.Windows.Forms.Padding(6);
            this.deskPanel.Size = new System.Drawing.Size(558, 194);
            this.deskPanel.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveBtn.Location = new System.Drawing.Point(6, 165);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(546, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // deskBox
            // 
            this.deskBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deskBox.Location = new System.Drawing.Point(6, 26);
            this.deskBox.Multiline = true;
            this.deskBox.Name = "deskBox";
            this.deskBox.Size = new System.Drawing.Size(546, 162);
            this.deskBox.TabIndex = 2;
            // 
            // deskLabel
            // 
            this.deskLabel.AutoSize = true;
            this.deskLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deskLabel.Location = new System.Drawing.Point(6, 6);
            this.deskLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.deskLabel.Size = new System.Drawing.Size(95, 20);
            this.deskLabel.TabIndex = 1;
            this.deskLabel.Text = "Описание";
            this.deskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.deskPanel);
            this.Controls.Add(this.namePanel);
            this.Name = "AddNoteForm";
            this.Text = "Добавить запись";
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.deskPanel.ResumeLayout(false);
            this.deskPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel deskPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label deskLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox deskBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}