namespace WinFormsEvents
{
    partial class ListEvForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rmvBtn = new System.Windows.Forms.Button();
            this.evListBox = new System.Windows.Forms.ListBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rmvBtn);
            this.mainPanel.Controls.Add(this.evListBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(584, 361);
            this.mainPanel.TabIndex = 0;
            // 
            // rmvBtn
            // 
            this.rmvBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rmvBtn.Location = new System.Drawing.Point(0, 338);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.Size = new System.Drawing.Size(584, 23);
            this.rmvBtn.TabIndex = 4;
            this.rmvBtn.Text = "Удалить";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // evListBox
            // 
            this.evListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evListBox.FormattingEnabled = true;
            this.evListBox.Location = new System.Drawing.Point(0, 0);
            this.evListBox.Name = "evListBox";
            this.evListBox.Size = new System.Drawing.Size(584, 361);
            this.evListBox.TabIndex = 3;
            // 
            // ListEvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.mainPanel);
            this.Name = "ListEvForm";
            this.Text = "Все события";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListBox evListBox;
        public System.Windows.Forms.Button rmvBtn;
    }
}