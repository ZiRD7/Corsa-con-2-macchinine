namespace Macchinine
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAvvia = new System.Windows.Forms.Button();
            this.lblTesto = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pcbFinishLine = new System.Windows.Forms.PictureBox();
            this.pcbMacchinaRossa = new System.Windows.Forms.PictureBox();
            this.pcbMacchinaNera = new System.Windows.Forms.PictureBox();
            this.pcbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMacchinaRossa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMacchinaNera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvvia
            // 
            this.btnAvvia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAvvia.Location = new System.Drawing.Point(1670, 587);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(70, 43);
            this.btnAvvia.TabIndex = 3;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesto.Location = new System.Drawing.Point(729, 29);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(102, 40);
            this.lblTesto.TabIndex = 4;
            this.lblTesto.Text = "label1";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStop.Location = new System.Drawing.Point(1595, 587);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(69, 43);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(1746, 587);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 43);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pcbFinishLine
            // 
            this.pcbFinishLine.Image = global::Macchinine.Properties.Resources.finishline;
            this.pcbFinishLine.Location = new System.Drawing.Point(1670, 29);
            this.pcbFinishLine.Name = "pcbFinishLine";
            this.pcbFinishLine.Size = new System.Drawing.Size(124, 538);
            this.pcbFinishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFinishLine.TabIndex = 7;
            this.pcbFinishLine.TabStop = false;
            // 
            // pcbMacchinaRossa
            // 
            this.pcbMacchinaRossa.AccessibleName = "Macchina rossa";
            this.pcbMacchinaRossa.Image = global::Macchinine.Properties.Resources.macchinarossa;
            this.pcbMacchinaRossa.Location = new System.Drawing.Point(33, 374);
            this.pcbMacchinaRossa.Name = "pcbMacchinaRossa";
            this.pcbMacchinaRossa.Size = new System.Drawing.Size(289, 139);
            this.pcbMacchinaRossa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMacchinaRossa.TabIndex = 2;
            this.pcbMacchinaRossa.TabStop = false;
            // 
            // pcbMacchinaNera
            // 
            this.pcbMacchinaNera.AccessibleName = "Macchina nera";
            this.pcbMacchinaNera.Image = global::Macchinine.Properties.Resources.macchinabianca;
            this.pcbMacchinaNera.Location = new System.Drawing.Point(33, 79);
            this.pcbMacchinaNera.Name = "pcbMacchinaNera";
            this.pcbMacchinaNera.Size = new System.Drawing.Size(289, 150);
            this.pcbMacchinaNera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMacchinaNera.TabIndex = 1;
            this.pcbMacchinaNera.TabStop = false;
            // 
            // pcbBackground
            // 
            this.pcbBackground.Image = global::Macchinine.Properties.Resources.road_trip_background_10864211;
            this.pcbBackground.Location = new System.Drawing.Point(12, 12);
            this.pcbBackground.Name = "pcbBackground";
            this.pcbBackground.Size = new System.Drawing.Size(1803, 583);
            this.pcbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackground.TabIndex = 0;
            this.pcbBackground.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1819, 629);
            this.Controls.Add(this.pcbFinishLine);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.pcbMacchinaRossa);
            this.Controls.Add(this.pcbMacchinaNera);
            this.Controls.Add(this.pcbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Corsa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMacchinaRossa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMacchinaNera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbBackground;
        private System.Windows.Forms.PictureBox pcbMacchinaNera;
        private System.Windows.Forms.PictureBox pcbMacchinaRossa;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pcbFinishLine;
    }
}

