
namespace OcjenskaVjezbaIvanMocilac13122021
{
    partial class Pocetna
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
            this.btn_UnosKorisnika = new System.Windows.Forms.Button();
            this.btnUnosPosudbe = new System.Windows.Forms.Button();
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_UnosKorisnika
            // 
            this.btn_UnosKorisnika.Location = new System.Drawing.Point(13, 13);
            this.btn_UnosKorisnika.Name = "btn_UnosKorisnika";
            this.btn_UnosKorisnika.Size = new System.Drawing.Size(110, 23);
            this.btn_UnosKorisnika.TabIndex = 0;
            this.btn_UnosKorisnika.Text = "Unos korisnika";
            this.btn_UnosKorisnika.UseVisualStyleBackColor = true;
            this.btn_UnosKorisnika.Click += new System.EventHandler(this.btn_UnosKorisnika_Click);
            // 
            // btnUnosPosudbe
            // 
            this.btnUnosPosudbe.Location = new System.Drawing.Point(129, 13);
            this.btnUnosPosudbe.Name = "btnUnosPosudbe";
            this.btnUnosPosudbe.Size = new System.Drawing.Size(90, 23);
            this.btnUnosPosudbe.TabIndex = 1;
            this.btnUnosPosudbe.Text = "Unos posudbe";
            this.btnUnosPosudbe.UseVisualStyleBackColor = true;
            this.btnUnosPosudbe.Click += new System.EventHandler(this.btnUnosPosudbe_Click);
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.Location = new System.Drawing.Point(225, 13);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(75, 23);
            this.btnUnosKnjige.TabIndex = 2;
            this.btnUnosKnjige.Text = "Unos knjige";
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            this.btnUnosKnjige.Click += new System.EventHandler(this.btnUnosKnjige_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 213);
            this.Controls.Add(this.btnUnosKnjige);
            this.Controls.Add(this.btnUnosPosudbe);
            this.Controls.Add(this.btn_UnosKorisnika);
            this.Name = "Pocetna";
            this.Text = "Početna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UnosKorisnika;
        private System.Windows.Forms.Button btnUnosPosudbe;
        private System.Windows.Forms.Button btnUnosKnjige;
    }
}

