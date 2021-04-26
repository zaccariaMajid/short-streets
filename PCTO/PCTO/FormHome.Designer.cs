
namespace PCTO
{
    partial class FormHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbSetActPosition = new System.Windows.Forms.GroupBox();
            this.txbCurTown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCurProvince = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCurStreet = new System.Windows.Forms.TextBox();
            this.txbCurNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbSetActPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpbSetActPosition);
            this.groupBox1.Location = new System.Drawing.Point(35, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your current position";
            // 
            // gpbSetActPosition
            // 
            this.gpbSetActPosition.Controls.Add(this.btnConfirm);
            this.gpbSetActPosition.Controls.Add(this.txbCurProvince);
            this.gpbSetActPosition.Controls.Add(this.label4);
            this.gpbSetActPosition.Controls.Add(this.label3);
            this.gpbSetActPosition.Controls.Add(this.txbCurNumber);
            this.gpbSetActPosition.Controls.Add(this.txbCurStreet);
            this.gpbSetActPosition.Controls.Add(this.label2);
            this.gpbSetActPosition.Controls.Add(this.label1);
            this.gpbSetActPosition.Controls.Add(this.txbCurTown);
            this.gpbSetActPosition.Location = new System.Drawing.Point(6, 21);
            this.gpbSetActPosition.Name = "gpbSetActPosition";
            this.gpbSetActPosition.Size = new System.Drawing.Size(937, 90);
            this.gpbSetActPosition.TabIndex = 0;
            this.gpbSetActPosition.TabStop = false;
            // 
            // txbCurTown
            // 
            this.txbCurTown.Location = new System.Drawing.Point(6, 49);
            this.txbCurTown.Name = "txbCurTown";
            this.txbCurTown.Size = new System.Drawing.Size(165, 22);
            this.txbCurTown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Town";
            // 
            // txbCurProvince
            // 
            this.txbCurProvince.Location = new System.Drawing.Point(221, 49);
            this.txbCurProvince.Name = "txbCurProvince";
            this.txbCurProvince.Size = new System.Drawing.Size(83, 22);
            this.txbCurProvince.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Province";
            // 
            // txbCurStreet
            // 
            this.txbCurStreet.Location = new System.Drawing.Point(364, 49);
            this.txbCurStreet.Name = "txbCurStreet";
            this.txbCurStreet.Size = new System.Drawing.Size(165, 22);
            this.txbCurStreet.TabIndex = 1;
            // 
            // txbCurNumber
            // 
            this.txbCurNumber.Location = new System.Drawing.Point(573, 49);
            this.txbCurNumber.Name = "txbCurNumber";
            this.txbCurNumber.Size = new System.Drawing.Size(83, 22);
            this.txbCurNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(761, 32);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(137, 39);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.groupBox1.ResumeLayout(false);
            this.gpbSetActPosition.ResumeLayout(false);
            this.gpbSetActPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbSetActPosition;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCurNumber;
        private System.Windows.Forms.TextBox txbCurStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCurProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCurTown;
    }
}