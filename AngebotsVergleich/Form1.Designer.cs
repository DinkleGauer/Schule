namespace AngebotsVergleich
{
    public class Angebot
    {
        public string Firma { get; set; }
        public int Listeneinkaufspreis { get; set; }
        public int Lieferrabatt { get; set; }
        public int Lieferskonto { get; set; }
        public int Bezugspreis { get; set; }

        public Angebot()
        {

        }
        public Angebot(string Firma ,int Listeneinkaufspreis, int Lieferrabatt, int Lieferskonto, int Bezugspreis)
        {
            Firma = Firma;
            Listeneinkaufspreis = Listeneinkaufspreis;
            Lieferrabatt = Lieferrabatt;
            Lieferskonto = Lieferskonto;
            Bezugspreis = Bezugspreis;
        }
    }
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // Funkt es???
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textListenPreis = new System.Windows.Forms.TextBox();
            this.textLieferSkonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLieferRabatt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBezugspreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AngebotErstellen = new System.Windows.Forms.Button();
            this.textFirma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textFirma2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBezugspreis2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLieferRabatt2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textLieferSkonto2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textListenPreis2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listeneinkaufspreis";
            // 
            // textListenPreis
            // 
            this.textListenPreis.Location = new System.Drawing.Point(177, 110);
            this.textListenPreis.Name = "textListenPreis";
            this.textListenPreis.Size = new System.Drawing.Size(125, 27);
            this.textListenPreis.TabIndex = 2;
            // 
            // textLieferSkonto
            // 
            this.textLieferSkonto.Location = new System.Drawing.Point(177, 192);
            this.textLieferSkonto.Name = "textLieferSkonto";
            this.textLieferSkonto.Size = new System.Drawing.Size(125, 27);
            this.textLieferSkonto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lieferskonto (%)";
            // 
            // textLieferRabatt
            // 
            this.textLieferRabatt.Location = new System.Drawing.Point(177, 151);
            this.textLieferRabatt.Name = "textLieferRabatt";
            this.textLieferRabatt.Size = new System.Drawing.Size(125, 27);
            this.textLieferRabatt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lieferrabatt (%)";
            // 
            // textBezugspreis
            // 
            this.textBezugspreis.Location = new System.Drawing.Point(177, 233);
            this.textBezugspreis.Name = "textBezugspreis";
            this.textBezugspreis.Size = new System.Drawing.Size(125, 27);
            this.textBezugspreis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bezugspreis";
            // 
            // AngebotErstellen
            // 
            this.AngebotErstellen.AutoSize = true;
            this.AngebotErstellen.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AngebotErstellen.Location = new System.Drawing.Point(254, 324);
            this.AngebotErstellen.Name = "AngebotErstellen";
            this.AngebotErstellen.Size = new System.Drawing.Size(301, 75);
            this.AngebotErstellen.TabIndex = 6;
            this.AngebotErstellen.Text = "Vergleichen";
            this.AngebotErstellen.UseVisualStyleBackColor = true;
            this.AngebotErstellen.Click += new System.EventHandler(this.Erstellen_click);
            // 
            // textFirma
            // 
            this.textFirma.Location = new System.Drawing.Point(177, 69);
            this.textFirma.Name = "textFirma";
            this.textFirma.Size = new System.Drawing.Size(125, 27);
            this.textFirma.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Firma";
            // 
            // textFirma2
            // 
            this.textFirma2.Location = new System.Drawing.Point(621, 69);
            this.textFirma2.Name = "textFirma2";
            this.textFirma2.Size = new System.Drawing.Size(125, 27);
            this.textFirma2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Firma";
            // 
            // textBezugspreis2
            // 
            this.textBezugspreis2.Location = new System.Drawing.Point(621, 233);
            this.textBezugspreis2.Name = "textBezugspreis2";
            this.textBezugspreis2.Size = new System.Drawing.Size(125, 27);
            this.textBezugspreis2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bezugspreis";
            // 
            // textLieferRabatt2
            // 
            this.textLieferRabatt2.Location = new System.Drawing.Point(621, 151);
            this.textLieferRabatt2.Name = "textLieferRabatt2";
            this.textLieferRabatt2.Size = new System.Drawing.Size(125, 27);
            this.textLieferRabatt2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Lieferrabatt (%)";
            // 
            // textLieferSkonto2
            // 
            this.textLieferSkonto2.Location = new System.Drawing.Point(621, 192);
            this.textLieferSkonto2.Name = "textLieferSkonto2";
            this.textLieferSkonto2.Size = new System.Drawing.Size(125, 27);
            this.textLieferSkonto2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lieferskonto (%)";
            // 
            // textListenPreis2
            // 
            this.textListenPreis2.Location = new System.Drawing.Point(621, 110);
            this.textListenPreis2.Name = "textListenPreis2";
            this.textListenPreis2.Size = new System.Drawing.Size(125, 27);
            this.textListenPreis2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Listeneinkaufspreis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(93, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "Angebot 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(558, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "Angebot 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textFirma2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBezugspreis2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textLieferRabatt2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textLieferSkonto2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textListenPreis2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textFirma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AngebotErstellen);
            this.Controls.Add(this.textBezugspreis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLieferRabatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLieferSkonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textListenPreis);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Angebots Vergleich";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textListenPreis;
        private TextBox textLieferSkonto;
        private Label label2;
        private TextBox textLieferRabatt;
        private Label label3;
        private TextBox textBezugspreis;
        private Label label4;
        private Button AngebotErstellen;
        private TextBox textFirma;
        private Label label6;
        private TextBox textFirma2;
        private Label label5;
        private TextBox textBezugspreis2;
        private Label label7;
        private TextBox textLieferRabatt2;
        private Label label8;
        private TextBox textLieferSkonto2;
        private Label label9;
        private TextBox textListenPreis2;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}