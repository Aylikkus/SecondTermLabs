namespace DataBase
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
            this.dataGridViewSoundCards = new System.Windows.Forms.DataGridView();
            this.topPanel = new System.Windows.Forms.Panel();
            this.scLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.rmvBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.asrtmntLabel = new System.Windows.Forms.Label();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.sLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.dataGridViewAssortment = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoundCards)).BeginInit();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.centralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssortment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSoundCards
            // 
            this.dataGridViewSoundCards.AllowUserToAddRows = false;
            this.dataGridViewSoundCards.AllowUserToDeleteRows = false;
            this.dataGridViewSoundCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoundCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSoundCards.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSoundCards.Location = new System.Drawing.Point(0, 13);
            this.dataGridViewSoundCards.Name = "dataGridViewSoundCards";
            this.dataGridViewSoundCards.ReadOnly = true;
            this.dataGridViewSoundCards.Size = new System.Drawing.Size(416, 174);
            this.dataGridViewSoundCards.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.dataGridViewSoundCards);
            this.topPanel.Controls.Add(this.scLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(416, 187);
            this.topPanel.TabIndex = 1;
            // 
            // scLabel
            // 
            this.scLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scLabel.Location = new System.Drawing.Point(0, 0);
            this.scLabel.Name = "scLabel";
            this.scLabel.Size = new System.Drawing.Size(416, 13);
            this.scLabel.TabIndex = 1;
            this.scLabel.Text = "Звуковые карты";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.editBtn);
            this.bottomPanel.Controls.Add(this.updateBtn);
            this.bottomPanel.Controls.Add(this.rmvBtn);
            this.bottomPanel.Controls.Add(this.addBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 418);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(800, 32);
            this.bottomPanel.TabIndex = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(329, 6);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // rmvBtn
            // 
            this.rmvBtn.Location = new System.Drawing.Point(122, 6);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.Size = new System.Drawing.Size(98, 23);
            this.rmvBtn.TabIndex = 4;
            this.rmvBtn.Text = "Удалить строку";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.rmvBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(104, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить строку";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // asrtmntLabel
            // 
            this.asrtmntLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.asrtmntLabel.Location = new System.Drawing.Point(6, 0);
            this.asrtmntLabel.Name = "asrtmntLabel";
            this.asrtmntLabel.Size = new System.Drawing.Size(378, 13);
            this.asrtmntLabel.TabIndex = 4;
            this.asrtmntLabel.Text = "Ассортимент";
            // 
            // centralPanel
            // 
            this.centralPanel.Controls.Add(this.dataGridViewShops);
            this.centralPanel.Controls.Add(this.sLabel);
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.Location = new System.Drawing.Point(0, 187);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(416, 231);
            this.centralPanel.TabIndex = 0;
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.AllowUserToAddRows = false;
            this.dataGridViewShops.AllowUserToDeleteRows = false;
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShops.Location = new System.Drawing.Point(0, 13);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.ReadOnly = true;
            this.dataGridViewShops.Size = new System.Drawing.Size(416, 218);
            this.dataGridViewShops.TabIndex = 3;
            // 
            // sLabel
            // 
            this.sLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sLabel.Location = new System.Drawing.Point(0, 0);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(416, 13);
            this.sLabel.TabIndex = 2;
            this.sLabel.Text = "Магазины";
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.dataGridViewAssortment);
            this.sidePanel.Controls.Add(this.asrtmntLabel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(416, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.sidePanel.Size = new System.Drawing.Size(384, 418);
            this.sidePanel.TabIndex = 2;
            // 
            // dataGridViewAssortment
            // 
            this.dataGridViewAssortment.AllowUserToAddRows = false;
            this.dataGridViewAssortment.AllowUserToDeleteRows = false;
            this.dataGridViewAssortment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssortment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAssortment.Location = new System.Drawing.Point(6, 13);
            this.dataGridViewAssortment.Name = "dataGridViewAssortment";
            this.dataGridViewAssortment.ReadOnly = true;
            this.dataGridViewAssortment.Size = new System.Drawing.Size(378, 405);
            this.dataGridViewAssortment.TabIndex = 5;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(226, 6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(97, 23);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "MainForm";
            this.Text = "Звуковые карты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoundCards)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.centralPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssortment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSoundCards;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label scLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label asrtmntLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.DataGridView dataGridViewAssortment;
        private System.Windows.Forms.Button rmvBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button editBtn;
    }
}

