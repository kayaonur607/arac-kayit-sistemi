namespace stajProje
{
    partial class musteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBoxAdi = new TextBox();
            mBoxTel = new MaskedTextBox();
            textBoxAdres = new TextBox();
            button3 = new Button();
            button5 = new Button();
            textBoxTc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "TC No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 135);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Adres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 96);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 57);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "Ad Soyad :";
            // 
            // textBoxAdi
            // 
            textBoxAdi.Location = new Point(110, 58);
            textBoxAdi.Name = "textBoxAdi";
            textBoxAdi.Size = new Size(243, 23);
            textBoxAdi.TabIndex = 2;
            // 
            // mBoxTel
            // 
            mBoxTel.Location = new Point(110, 97);
            mBoxTel.Mask = "(999) 000-0000";
            mBoxTel.Name = "mBoxTel";
            mBoxTel.Size = new Size(243, 23);
            mBoxTel.TabIndex = 3;
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(110, 136);
            textBoxAdres.Multiline = true;
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(243, 94);
            textBoxAdres.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(127, 286);
            button3.Name = "button3";
            button3.Size = new Size(239, 58);
            button3.TabIndex = 6;
            button3.Text = "Müşteri Ekle";
            button3.TextAlign = ContentAlignment.MiddleRight;
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
            button5.Location = new Point(8, 286);
            button5.Name = "button5";
            button5.Size = new Size(113, 58);
            button5.TabIndex = 5;
            button5.Text = "Çıkış";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(110, 20);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(243, 23);
            textBoxTc.TabIndex = 1;
            // 
            // musteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 356);
            Controls.Add(textBoxTc);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBoxAdres);
            Controls.Add(mBoxTel);
            Controls.Add(textBoxAdi);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "musteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBoxAdi;
        private MaskedTextBox mBoxTel;
        private TextBox textBoxAdres;
        private Button button3;
        private Button button5;
        private TextBox textBoxTc;
    }
}