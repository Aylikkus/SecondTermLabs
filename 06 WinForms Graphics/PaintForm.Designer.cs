namespace WinFormsGraphics
{
    partial class PaintForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newLineBzBtn = new System.Windows.Forms.Button();
            this.dashStyleDomUpDown = new System.Windows.Forms.DomainUpDown();
            this.widthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.newLineBzBtn);
            this.panel1.Controls.Add(this.dashStyleDomUpDown);
            this.panel1.Controls.Add(this.widthNumUpDown);
            this.panel1.Controls.Add(this.colorPanel);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 1;
            // 
            // newLineBzBtn
            // 
            this.newLineBzBtn.Location = new System.Drawing.Point(713, 3);
            this.newLineBzBtn.Name = "newLineBzBtn";
            this.newLineBzBtn.Size = new System.Drawing.Size(84, 23);
            this.newLineBzBtn.TabIndex = 3;
            this.newLineBzBtn.Text = "Новая линия";
            this.newLineBzBtn.UseVisualStyleBackColor = true;
            this.newLineBzBtn.Click += new System.EventHandler(this.newLineBzBtn_Click);
            // 
            // dashStyleDomUpDown
            // 
            this.dashStyleDomUpDown.Items.Add("Обычный");
            this.dashStyleDomUpDown.Items.Add("Штриховой");
            this.dashStyleDomUpDown.Items.Add("Пунктирный");
            this.dashStyleDomUpDown.Items.Add("Штрихпунктирный");
            this.dashStyleDomUpDown.Items.Add("Штрих с двумя пунктирами");
            this.dashStyleDomUpDown.Location = new System.Drawing.Point(240, 6);
            this.dashStyleDomUpDown.Name = "dashStyleDomUpDown";
            this.dashStyleDomUpDown.Size = new System.Drawing.Size(201, 20);
            this.dashStyleDomUpDown.TabIndex = 2;
            this.dashStyleDomUpDown.Text = "Стиль";
            this.dashStyleDomUpDown.SelectedItemChanged += new System.EventHandler(this.dashStyleDomUpDown_SelectedItemChanged);
            // 
            // widthNumUpDown
            // 
            this.widthNumUpDown.Location = new System.Drawing.Point(194, 6);
            this.widthNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumUpDown.Name = "widthNumUpDown";
            this.widthNumUpDown.Size = new System.Drawing.Size(40, 20);
            this.widthNumUpDown.TabIndex = 0;
            this.widthNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumUpDown.ValueChanged += new System.EventHandler(this.widthNumUpDown_ValueChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.Location = new System.Drawing.Point(165, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(23, 23);
            this.colorPanel.TabIndex = 2;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(84, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseMnemonic = false;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "PaintForm";
            this.Text = "Линии Безье";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widthNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.NumericUpDown widthNumUpDown;
        private System.Windows.Forms.DomainUpDown dashStyleDomUpDown;
        private System.Windows.Forms.Button newLineBzBtn;
    }
}

