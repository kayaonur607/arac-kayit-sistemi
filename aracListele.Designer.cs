namespace stajProje
{
    partial class aracListele
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aracListele));
            dataGridView1 = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBoxMarka = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBoxPlaka = new TextBox();
            textBoxUcret = new TextBox();
            textBoxModel = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            aracListeleBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aracListeleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(519, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(178, 243);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(127, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 246);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 34;
            label7.Text = "Muayene Tarihi :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(178, 19);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 19);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 32;
            label6.Text = "Araç Sahibi :";
            // 
            // textBoxMarka
            // 
            textBoxMarka.Location = new Point(178, 92);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(126, 23);
            textBoxMarka.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Geçti", "Kaldı" });
            comboBox1.Location = new Point(178, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 29;
            label4.Text = "Muayene Durumu :";
            // 
            // textBoxPlaka
            // 
            textBoxPlaka.Location = new Point(178, 54);
            textBoxPlaka.MaxLength = 11;
            textBoxPlaka.Name = "textBoxPlaka";
            textBoxPlaka.Size = new Size(126, 23);
            textBoxPlaka.TabIndex = 2;
            // 
            // textBoxUcret
            // 
            textBoxUcret.Location = new Point(178, 169);
            textBoxUcret.Name = "textBoxUcret";
            textBoxUcret.Size = new Size(126, 23);
            textBoxUcret.TabIndex = 5;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(178, 131);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(126, 23);
            textBoxModel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 28;
            label5.Text = "Araç Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 26;
            label3.Text = "Araç Marka :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 24;
            label2.Text = "Muayene Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 22;
            label1.Text = "Araç Plaka :";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(709, 346);
            button5.Name = "button5";
            button5.Size = new Size(134, 54);
            button5.TabIndex = 10;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(168, 285);
            button1.Name = "button1";
            button1.Size = new Size(150, 54);
            button1.TabIndex = 9;
            button1.Text = "Araç Sil";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 286);
            button3.Name = "button3";
            button3.Size = new Size(150, 54);
            button3.TabIndex = 8;
            button3.Text = "Araç\r\nGüncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // aracListeleBindingSource
            // 
            aracListeleBindingSource.DataSource = typeof(aracListele);
            // 
            // aracListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(855, 412);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
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
            Controls.Add(dataGridView1);
            Name = "aracListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "aracListele";
            Load += aracListele_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)aracListeleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBoxMarka;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBoxPlaka;
        private TextBox textBoxUcret;
        private TextBox textBoxModel;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button button1;
        private Button button3;
        private BindingSource aracListeleBindingSource;
    }
}