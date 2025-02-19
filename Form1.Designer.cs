namespace каталог
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.regPanel = new System.Windows.Forms.Panel();
            this.redBut = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrPanel = new System.Windows.Forms.Panel();
            this.findBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.hideBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regPanel.SuspendLayout();
            this.filtrPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regPanel.Controls.Add(this.redBut);
            this.regPanel.Controls.Add(this.Password);
            this.regPanel.Controls.Add(this.label2);
            this.regPanel.Controls.Add(this.loginText);
            this.regPanel.Controls.Add(this.label1);
            this.regPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regPanel.Location = new System.Drawing.Point(0, 0);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(1060, 104);
            this.regPanel.TabIndex = 0;
            // 
            // redBut
            // 
            this.redBut.Location = new System.Drawing.Point(650, 37);
            this.redBut.Name = "redBut";
            this.redBut.Size = new System.Drawing.Size(202, 37);
            this.redBut.TabIndex = 4;
            this.redBut.Text = "Войти";
            this.redBut.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(422, 45);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(150, 30);
            this.Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(163, 45);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(150, 30);
            this.loginText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // filtrPanel
            // 
            this.filtrPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.filtrPanel.Controls.Add(this.findBut);
            this.filtrPanel.Controls.Add(this.label4);
            this.filtrPanel.Controls.Add(this.comboBox1);
            this.filtrPanel.Controls.Add(this.nameText);
            this.filtrPanel.Controls.Add(this.hideBut);
            this.filtrPanel.Controls.Add(this.label3);
            this.filtrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtrPanel.Location = new System.Drawing.Point(0, 104);
            this.filtrPanel.Name = "filtrPanel";
            this.filtrPanel.Size = new System.Drawing.Size(1060, 131);
            this.filtrPanel.TabIndex = 1;
            // 
            // findBut
            // 
            this.findBut.Location = new System.Drawing.Point(932, 47);
            this.findBut.Name = "findBut";
            this.findBut.Size = new System.Drawing.Size(116, 37);
            this.findBut.TabIndex = 9;
            this.findBut.Text = "Найти";
            this.findBut.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Жанр";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Стратегия",
            "Шутер",
            "Сюжет",
            "Выживание"});
            this.comboBox1.Location = new System.Drawing.Point(400, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(125, 50);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(150, 30);
            this.nameText.TabIndex = 6;
            // 
            // hideBut
            // 
            this.hideBut.Location = new System.Drawing.Point(0, 0);
            this.hideBut.Name = "hideBut";
            this.hideBut.Size = new System.Drawing.Size(154, 31);
            this.hideBut.TabIndex = 0;
            this.hideBut.Text = "Развернуть";
            this.hideBut.UseVisualStyleBackColor = true;
            this.hideBut.Click += new System.EventHandler(this.hideBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.label6);
            this.menuPanel.Controls.Add(this.pictureBox2);
            this.menuPanel.Controls.Add(this.label5);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 235);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1060, 414);
            this.menuPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dota2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Dota2";
            this.pictureBox2.Click += new System.EventHandler(this.picture_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Half-Life";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Half-Life";
            this.pictureBox1.Click += new System.EventHandler(this.picture_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 649);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.filtrPanel);
            this.Controls.Add(this.regPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.filtrPanel.ResumeLayout(false);
            this.filtrPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Button redBut;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel filtrPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button hideBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

