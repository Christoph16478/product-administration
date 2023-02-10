
namespace Produktverwaltung
{
    /// <summary>Controller class <c>WinFormTools</c>
    /// allows selection of lines in products table.</summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvProdukt = new System.Windows.Forms.DataGridView();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnXSuchen = new System.Windows.Forms.Button();
            this.txtProduktId = new System.Windows.Forms.TextBox();
            this.txtKategorie = new System.Windows.Forms.TextBox();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMengeProEinheit = new System.Windows.Forms.TextBox();
            this.txtPreisProEinheit = new System.Windows.Forms.TextBox();
            this.txtEinheitVorbestellt = new System.Windows.Forms.TextBox();
            this.txtEinheitAufLager = new System.Windows.Forms.TextBox();
            this.txtNachbestellungsStufe = new System.Windows.Forms.TextBox();
            this.txtProduktionEingestellt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukt
            // 
            this.dgvProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukt.Location = new System.Drawing.Point(22, 415);
            this.dgvProdukt.Name = "dgvProdukt";
            this.dgvProdukt.RowHeadersWidth = 51;
            this.dgvProdukt.RowTemplate.Height = 24;
            this.dgvProdukt.Size = new System.Drawing.Size(987, 260);
            this.dgvProdukt.TabIndex = 0;
            // 
            // btnNeu
            // 
            this.btnNeu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNeu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNeu.Location = new System.Drawing.Point(22, 361);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(161, 48);
            this.btnNeu.TabIndex = 1;
            this.btnNeu.Text = "NEU";
            this.btnNeu.UseVisualStyleBackColor = false;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLoeschen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoeschen.Location = new System.Drawing.Point(189, 361);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(151, 48);
            this.btnLoeschen.TabIndex = 2;
            this.btnLoeschen.Text = "LÖSCHEN";
            this.btnLoeschen.UseVisualStyleBackColor = false;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSpeichern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSpeichern.Location = new System.Drawing.Point(346, 361);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(165, 48);
            this.btnSpeichern.TabIndex = 3;
            this.btnSpeichern.Text = "SPEICHERN";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSuchen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuchen.Location = new System.Drawing.Point(831, 361);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(178, 48);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "SUCHEN";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // btnXSuchen
            // 
            this.btnXSuchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXSuchen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXSuchen.Location = new System.Drawing.Point(759, 361);
            this.btnXSuchen.Name = "btnXSuchen";
            this.btnXSuchen.Size = new System.Drawing.Size(66, 48);
            this.btnXSuchen.TabIndex = 5;
            this.btnXSuchen.Text = "X";
            this.btnXSuchen.UseVisualStyleBackColor = false;
            this.btnXSuchen.Click += new System.EventHandler(this.btnXSuchen_Click);
            // 
            // txtProduktId
            // 
            this.txtProduktId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProduktId.Location = new System.Drawing.Point(157, 169);
            this.txtProduktId.Name = "txtProduktId";
            this.txtProduktId.Size = new System.Drawing.Size(236, 30);
            this.txtProduktId.TabIndex = 6;
            // 
            // txtKategorie
            // 
            this.txtKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKategorie.Location = new System.Drawing.Point(157, 309);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(236, 30);
            this.txtKategorie.TabIndex = 7;
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBeschreibung.Location = new System.Drawing.Point(157, 264);
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(236, 30);
            this.txtBeschreibung.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(157, 218);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 30);
            this.txtName.TabIndex = 9;
            // 
            // txtMengeProEinheit
            // 
            this.txtMengeProEinheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMengeProEinheit.Location = new System.Drawing.Point(754, 190);
            this.txtMengeProEinheit.Name = "txtMengeProEinheit";
            this.txtMengeProEinheit.Size = new System.Drawing.Size(236, 30);
            this.txtMengeProEinheit.TabIndex = 10;
            // 
            // txtPreisProEinheit
            // 
            this.txtPreisProEinheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPreisProEinheit.Location = new System.Drawing.Point(452, 190);
            this.txtPreisProEinheit.Name = "txtPreisProEinheit";
            this.txtPreisProEinheit.Size = new System.Drawing.Size(236, 30);
            this.txtPreisProEinheit.TabIndex = 11;
            // 
            // txtEinheitVorbestellt
            // 
            this.txtEinheitVorbestellt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEinheitVorbestellt.Location = new System.Drawing.Point(754, 251);
            this.txtEinheitVorbestellt.Name = "txtEinheitVorbestellt";
            this.txtEinheitVorbestellt.Size = new System.Drawing.Size(236, 30);
            this.txtEinheitVorbestellt.TabIndex = 12;
            // 
            // txtEinheitAufLager
            // 
            this.txtEinheitAufLager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEinheitAufLager.Location = new System.Drawing.Point(452, 251);
            this.txtEinheitAufLager.Name = "txtEinheitAufLager";
            this.txtEinheitAufLager.Size = new System.Drawing.Size(236, 30);
            this.txtEinheitAufLager.TabIndex = 13;
            // 
            // txtNachbestellungsStufe
            // 
            this.txtNachbestellungsStufe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNachbestellungsStufe.Location = new System.Drawing.Point(452, 312);
            this.txtNachbestellungsStufe.Name = "txtNachbestellungsStufe";
            this.txtNachbestellungsStufe.Size = new System.Drawing.Size(236, 30);
            this.txtNachbestellungsStufe.TabIndex = 14;
            // 
            // txtProduktionEingestellt
            // 
            this.txtProduktionEingestellt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProduktionEingestellt.Location = new System.Drawing.Point(754, 312);
            this.txtProduktionEingestellt.Name = "txtProduktionEingestellt";
            this.txtProduktionEingestellt.Size = new System.Drawing.Size(236, 30);
            this.txtProduktionEingestellt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(56, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ProduktId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(87, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Beschreibung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(55, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kategorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(447, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "PreisProEinheit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(749, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "MengeProEinheit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(447, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "EinheitAufLager";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(748, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "EinheitVorbestellt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(447, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "NachbestellungsStufe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(749, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "ProduktionEingestellt";
            // 
            // txtSuchen
            // 
            this.txtSuchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSuchen.Location = new System.Drawing.Point(517, 370);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(236, 30);
            this.txtSuchen.TabIndex = 26;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerLabel.Location = new System.Drawing.Point(16, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(699, 46);
            this.headerLabel.TabIndex = 27;
            this.headerLabel.Text = "Produktverwaltung der Traumfirma AG\r\n";
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLabel.Location = new System.Drawing.Point(20, 61);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(991, 96);
            this.txtLabel.TabIndex = 28;
            this.txtLabel.Text = resources.GetString("txtLabel.Text");
            // 
            // imgBox
            // 
            this.imgBox.Image = ((System.Drawing.Image)(resources.GetObject("imgBox.Image")));
            this.imgBox.Location = new System.Drawing.Point(786, 9);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(239, 72);
            this.imgBox.TabIndex = 29;
            this.imgBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 705);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduktionEingestellt);
            this.Controls.Add(this.txtNachbestellungsStufe);
            this.Controls.Add(this.txtEinheitAufLager);
            this.Controls.Add(this.txtEinheitVorbestellt);
            this.Controls.Add(this.txtPreisProEinheit);
            this.Controls.Add(this.txtMengeProEinheit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.txtKategorie);
            this.Controls.Add(this.txtProduktId);
            this.Controls.Add(this.btnXSuchen);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.dgvProdukt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukt;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnXSuchen;
        private System.Windows.Forms.TextBox txtProduktId;
        private System.Windows.Forms.TextBox txtKategorie;
        private System.Windows.Forms.TextBox txtBeschreibung;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMengeProEinheit;
        private System.Windows.Forms.TextBox txtPreisProEinheit;
        private System.Windows.Forms.TextBox txtEinheitVorbestellt;
        private System.Windows.Forms.TextBox txtEinheitAufLager;
        private System.Windows.Forms.TextBox txtNachbestellungsStufe;
        private System.Windows.Forms.TextBox txtProduktionEingestellt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSuchen;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

