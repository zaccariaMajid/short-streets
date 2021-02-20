
namespace Shorts_Street
{
    partial class Form1
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
            this.btnpercorsominimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpercorsominimo
            // 
            this.btnpercorsominimo.Location = new System.Drawing.Point(116, 95);
            this.btnpercorsominimo.Name = "btnpercorsominimo";
            this.btnpercorsominimo.Size = new System.Drawing.Size(125, 46);
            this.btnpercorsominimo.TabIndex = 0;
            this.btnpercorsominimo.Text = "PERCORSO MINIMO";
            this.btnpercorsominimo.UseVisualStyleBackColor = true;
            this.btnpercorsominimo.Click += new System.EventHandler(this.btnpercorsominimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpercorsominimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpercorsominimo;
    }
}

