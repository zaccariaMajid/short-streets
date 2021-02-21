
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpercorsominimo
            // 
            this.btnpercorsominimo.Location = new System.Drawing.Point(155, 117);
            this.btnpercorsominimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnpercorsominimo.Name = "btnpercorsominimo";
            this.btnpercorsominimo.Size = new System.Drawing.Size(167, 57);
            this.btnpercorsominimo.TabIndex = 0;
            this.btnpercorsominimo.Text = "PERCORSO MINIMO";
            this.btnpercorsominimo.UseVisualStyleBackColor = true;
            this.btnpercorsominimo.Click += new System.EventHandler(this.btnpercorsominimo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "PESO VOLUME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpercorsominimo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpercorsominimo;
        private System.Windows.Forms.Button button1;
    }
}

