namespace WinFormsEvents
{
    partial class AddEvForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(384, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Имя...";
            this.nameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            // 
            // descTextBox
            // 
            this.descTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descTextBox.Location = new System.Drawing.Point(0, 20);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(384, 141);
            this.descTextBox.TabIndex = 1;
            this.descTextBox.Text = "Описание...";
            this.descTextBox.Enter += new System.EventHandler(this.DescTextBox_Enter);
            // 
            // checkBtn
            // 
            this.checkBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBtn.Location = new System.Drawing.Point(0, 138);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(384, 23);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Добавить";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // AddEvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddEvForm";
            this.Text = "Добавить событие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button checkBtn;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox descTextBox;
    }
}