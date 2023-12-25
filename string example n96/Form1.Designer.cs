namespace string_example_n96
{
    partial class Form1
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnBuyult = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnSay = new System.Windows.Forms.Button();
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.btnBirlestir = new System.Windows.Forms.Button();
            this.btnSiraGetir = new System.Windows.Forms.Button();
            this.btnKacis = new System.Windows.Forms.Button();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.btnBicim = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSplite = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(12, 43);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(267, 20);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "merhaba dünya, ben Hilal De Souza!";
            // 
            // btnBuyult
            // 
            this.btnBuyult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyult.Location = new System.Drawing.Point(12, 125);
            this.btnBuyult.Name = "btnBuyult";
            this.btnBuyult.Size = new System.Drawing.Size(165, 42);
            this.btnBuyult.TabIndex = 1;
            this.btnBuyult.Text = "Hepsini Büyük Yap";
            this.btnBuyult.UseVisualStyleBackColor = true;
            this.btnBuyult.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(16, 84);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(332, 22);
            this.txtMesaj.TabIndex = 2;
            // 
            // btnKucult
            // 
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.Location = new System.Drawing.Point(12, 173);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(165, 42);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "Hepsini Küçük Yap";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnSay
            // 
            this.btnSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSay.Location = new System.Drawing.Point(183, 173);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(165, 42);
            this.btnSay.TabIndex = 4;
            this.btnSay.Text = "Karakter Sayısını Göster";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajVer.Location = new System.Drawing.Point(183, 125);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(165, 42);
            this.btnMesajVer.TabIndex = 5;
            this.btnMesajVer.Text = "Mesaj Ver";
            this.btnMesajVer.UseVisualStyleBackColor = true;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // btnBirlestir
            // 
            this.btnBirlestir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirlestir.Location = new System.Drawing.Point(12, 221);
            this.btnBirlestir.Name = "btnBirlestir";
            this.btnBirlestir.Size = new System.Drawing.Size(165, 42);
            this.btnBirlestir.TabIndex = 6;
            this.btnBirlestir.Text = "Metin Birleştir";
            this.btnBirlestir.UseVisualStyleBackColor = true;
            this.btnBirlestir.Click += new System.EventHandler(this.btnMetin_Click);
            // 
            // btnSiraGetir
            // 
            this.btnSiraGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiraGetir.Location = new System.Drawing.Point(183, 221);
            this.btnSiraGetir.Name = "btnSiraGetir";
            this.btnSiraGetir.Size = new System.Drawing.Size(165, 42);
            this.btnSiraGetir.TabIndex = 7;
            this.btnSiraGetir.Text = "Sıra Getir";
            this.btnSiraGetir.UseVisualStyleBackColor = true;
            this.btnSiraGetir.Click += new System.EventHandler(this.btnSiraGetir_Click);
            // 
            // btnKacis
            // 
            this.btnKacis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKacis.Location = new System.Drawing.Point(12, 269);
            this.btnKacis.Name = "btnKacis";
            this.btnKacis.Size = new System.Drawing.Size(165, 42);
            this.btnKacis.TabIndex = 8;
            this.btnKacis.Text = "Kaçış Karakteri";
            this.btnKacis.UseVisualStyleBackColor = true;
            this.btnKacis.Click += new System.EventHandler(this.btnKacis1_Click);
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarsilastir.Location = new System.Drawing.Point(183, 269);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(165, 42);
            this.btnKarsilastir.TabIndex = 9;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // btnBicim
            // 
            this.btnBicim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBicim.Location = new System.Drawing.Point(12, 317);
            this.btnBicim.Name = "btnBicim";
            this.btnBicim.Size = new System.Drawing.Size(165, 42);
            this.btnBicim.TabIndex = 10;
            this.btnBicim.Text = "Biçimlendirme";
            this.btnBicim.UseVisualStyleBackColor = true;
            this.btnBicim.Click += new System.EventHandler(this.btnBicim_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompare.Location = new System.Drawing.Point(183, 317);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(165, 42);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare Kullanımı";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(12, 365);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 42);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContains.Location = new System.Drawing.Point(183, 365);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(165, 42);
            this.btnContains.TabIndex = 13;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReplace.Location = new System.Drawing.Point(12, 413);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(165, 42);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSplite
            // 
            this.btnSplite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSplite.Location = new System.Drawing.Point(183, 413);
            this.btnSplite.Name = "btnSplite";
            this.btnSplite.Size = new System.Drawing.Size(165, 42);
            this.btnSplite.TabIndex = 15;
            this.btnSplite.Text = "Splite";
            this.btnSplite.UseVisualStyleBackColor = true;
            this.btnSplite.Click += new System.EventHandler(this.btnSplite_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(354, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 329);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 492);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSplite);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnBicim);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.btnKacis);
            this.Controls.Add(this.btnSiraGetir);
            this.Controls.Add(this.btnBirlestir);
            this.Controls.Add(this.btnMesajVer);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btnBuyult);
            this.Controls.Add(this.lblMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnBuyult;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btnMesajVer;
        private System.Windows.Forms.Button btnBirlestir;
        private System.Windows.Forms.Button btnSiraGetir;
        private System.Windows.Forms.Button btnKacis;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Button btnBicim;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSplite;
        private System.Windows.Forms.ListBox listBox1;
    }
}

