namespace stajProje
{
    partial class aracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aracEkle));
            textBoxPlaka = new TextBox();
            textBoxUcret = new TextBox();
            textBoxModel = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBoxMarka = new TextBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            button5 = new Button();
            button3 = new Button();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxPlaka
            // 
            textBoxPlaka.Location = new Point(173, 47);
            textBoxPlaka.MaxLength = 11;
            textBoxPlaka.Name = "textBoxPlaka";
            textBoxPlaka.Size = new Size(212, 23);
            textBoxPlaka.TabIndex = 2;
            // 
            // textBoxUcret
            // 
            textBoxUcret.Location = new Point(173, 162);
            textBoxUcret.Name = "textBoxUcret";
            textBoxUcret.Size = new Size(212, 23);
            textBoxUcret.TabIndex = 5;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(173, 124);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(212, 23);
            textBoxModel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 123);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 12;
            label5.Text = "Araç Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 84);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 9;
            label3.Text = "Araç Marka :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 162);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Muayene Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 46);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 5;
            label1.Text = "Araç Plaka :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 200);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 13;
            label4.Text = "Muayene Durumu :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Geçti", "Kaldı" });
            comboBox1.Location = new Point(173, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 6;
            // 
            // textBoxMarka
            // 
            textBoxMarka.Location = new Point(173, 85);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(212, 23);
            textBoxMarka.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(173, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 23);
            comboBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 12);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 16;
            label6.Text = "Araç Sahibi :";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(7, 289);
            button5.Name = "button5";
            button5.Size = new Size(113, 58);
            button5.TabIndex = 8;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Coral;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(147, 289);
            button3.Name = "button3";
            button3.Size = new Size(239, 58);
            button3.TabIndex = 9;
            button3.Text = "Araç Ekle";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 239);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 20;
            label7.Text = "Muayene Tarihi :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(173, 236);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(213, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // aracEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(397, 380);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(textBoxMarka);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBoxPlaka);
            Controls.Add(textBoxUcret);
            Controls.Add(textBoxModel);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "aracEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "aracEkle";
            Load += aracEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPlaka;
        private TextBox textBoxUcret;
        private TextBox textBoxModel;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBoxMarka;
        private ComboBox comboBox2;
        private Label label6;
        private Button button5;
        private Button button3;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
    }
}