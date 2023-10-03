namespace stajProje
{
    partial class musteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriListele));
            dataGridView1 = new DataGridView();
            textBoxTc = new TextBox();
            textBoxAdres = new TextBox();
            mBoxTel = new MaskedTextBox();
            textBoxAdi = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(114, 20);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(194, 23);
            textBoxTc.TabIndex = 1;
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(114, 136);
            textBoxAdres.Multiline = true;
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(194, 85);
            textBoxAdres.TabIndex = 4;
            // 
            // mBoxTel
            // 
            mBoxTel.Location = new Point(114, 97);
            mBoxTel.Mask = "(999) 000-0000";
            mBoxTel.Name = "mBoxTel";
            mBoxTel.Size = new Size(194, 23);
            mBoxTel.TabIndex = 3;
            // 
            // textBoxAdi
            // 
            textBoxAdi.Location = new Point(115, 58);
            textBoxAdi.Name = "textBoxAdi";
            textBoxAdi.Size = new Size(193, 23);
            textBoxAdi.TabIndex = 2;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 57);
            label5.Name = "label5";
            label5.Size = new Size(106, 39);
            label5.TabIndex = 18;
            label5.Text = "Ad Soyad :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(84, 39);
            label3.TabIndex = 17;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(81, 39);
            label2.TabIndex = 16;
            label2.Text = "Adres :";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 39);
            label1.TabIndex = 15;
            label1.Text = "TC No :";
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 292);
            button3.Name = "button3";
            button3.Size = new Size(150, 54);
            button3.TabIndex = 5;
            button3.Text = "Müşteri\r\nGüncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(709, 346);
            button5.Name = "button5";
            button5.Size = new Size(134, 54);
            button5.TabIndex = 7;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(168, 291);
            button1.Name = "button1";
            button1.Size = new Size(150, 54);
            button1.TabIndex = 6;
            button1.Text = "Müşteri Sil";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // musteriListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(855, 412);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBoxTc);
            Controls.Add(textBoxAdres);
            Controls.Add(mBoxTel);
            Controls.Add(textBoxAdi);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "musteriListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "musteriListele";
            Load += musteriListele_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxTc;
        private TextBox textBoxAdres;
        private MaskedTextBox mBoxTel;
        private TextBox textBoxAdi;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button5;
        private Button button1;
    }
}