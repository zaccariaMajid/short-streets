
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
            this.gpbSetCurAddress = new System.Windows.Forms.GroupBox();
            this.btnSimulatePrevious = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrevious = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txbCurProvince = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCurNumber = new System.Windows.Forms.TextBox();
            this.txbCurStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCurTown = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblCurrentAddress = new System.Windows.Forms.Label();
            this.gpbCurrentAddress = new System.Windows.Forms.GroupBox();
            this.gpbSetCurAddress.SuspendLayout();
            this.gpbCurrentAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSetCurAddress
            // 
            this.gpbSetCurAddress.Controls.Add(this.btnSimulatePrevious);
            this.gpbSetCurAddress.Controls.Add(this.label5);
            this.gpbSetCurAddress.Controls.Add(this.cmbPrevious);
            this.gpbSetCurAddress.Controls.Add(this.btnConfirm);
            this.gpbSetCurAddress.Controls.Add(this.txbCurProvince);
            this.gpbSetCurAddress.Controls.Add(this.label4);
            this.gpbSetCurAddress.Controls.Add(this.label3);
            this.gpbSetCurAddress.Controls.Add(this.txbCurNumber);
            this.gpbSetCurAddress.Controls.Add(this.txbCurStreet);
            this.gpbSetCurAddress.Controls.Add(this.label2);
            this.gpbSetCurAddress.Controls.Add(this.label1);
            this.gpbSetCurAddress.Controls.Add(this.txbCurTown);
            this.gpbSetCurAddress.Location = new System.Drawing.Point(97, 130);
            this.gpbSetCurAddress.Name = "gpbSetCurAddress";
            this.gpbSetCurAddress.Size = new System.Drawing.Size(831, 144);
            this.gpbSetCurAddress.TabIndex = 0;
            this.gpbSetCurAddress.TabStop = false;
            this.gpbSetCurAddress.Text = "Set your current address";
            // 
            // btnSimulatePrevious
            // 
            this.btnSimulatePrevious.Location = new System.Drawing.Point(418, 105);
            this.btnSimulatePrevious.Name = "btnSimulatePrevious";
            this.btnSimulatePrevious.Size = new System.Drawing.Size(144, 30);
            this.btnSimulatePrevious.TabIndex = 9;
            this.btnSimulatePrevious.Text = "Simulate previous";
            this.btnSimulatePrevious.UseVisualStyleBackColor = true;
            this.btnSimulatePrevious.Click += new System.EventHandler(this.btnSimulatePrevious_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Previous";
            // 
            // cmbPrevious
            // 
            this.cmbPrevious.FormattingEnabled = true;
            this.cmbPrevious.Location = new System.Drawing.Point(9, 109);
            this.cmbPrevious.Name = "cmbPrevious";
            this.cmbPrevious.Size = new System.Drawing.Size(403, 24);
            this.cmbPrevious.TabIndex = 7;
            this.cmbPrevious.SelectedIndexChanged += new System.EventHandler(this.cmbPrevious_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(686, 42);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(137, 39);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txbCurProvince
            // 
            this.txbCurProvince.Location = new System.Drawing.Point(192, 50);
            this.txbCurProvince.Name = "txbCurProvince";
            this.txbCurProvince.Size = new System.Drawing.Size(83, 22);
            this.txbCurProvince.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street";
            // 
            // txbCurNumber
            // 
            this.txbCurNumber.Location = new System.Drawing.Point(464, 50);
            this.txbCurNumber.Name = "txbCurNumber";
            this.txbCurNumber.Size = new System.Drawing.Size(83, 22);
            this.txbCurNumber.TabIndex = 1;
            // 
            // txbCurStreet
            // 
            this.txbCurStreet.Location = new System.Drawing.Point(281, 50);
            this.txbCurStreet.Name = "txbCurStreet";
            this.txbCurStreet.Size = new System.Drawing.Size(177, 22);
            this.txbCurStreet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Province";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Town";
            // 
            // txbCurTown
            // 
            this.txbCurTown.Location = new System.Drawing.Point(9, 50);
            this.txbCurTown.Name = "txbCurTown";
            this.txbCurTown.Size = new System.Drawing.Size(177, 22);
            this.txbCurTown.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(686, 31);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(137, 28);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblCurrentAddress
            // 
            this.lblCurrentAddress.AutoSize = true;
            this.lblCurrentAddress.Location = new System.Drawing.Point(18, 37);
            this.lblCurrentAddress.Name = "lblCurrentAddress";
            this.lblCurrentAddress.Size = new System.Drawing.Size(8, 17);
            this.lblCurrentAddress.TabIndex = 1;
            this.lblCurrentAddress.Text = "\r\n";
            // 
            // gpbCurrentAddress
            // 
            this.gpbCurrentAddress.Controls.Add(this.lblCurrentAddress);
            this.gpbCurrentAddress.Controls.Add(this.btnChange);
            this.gpbCurrentAddress.Enabled = false;
            this.gpbCurrentAddress.Location = new System.Drawing.Point(97, 280);
            this.gpbCurrentAddress.Name = "gpbCurrentAddress";
            this.gpbCurrentAddress.Size = new System.Drawing.Size(831, 76);
            this.gpbCurrentAddress.TabIndex = 3;
            this.gpbCurrentAddress.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.gpbCurrentAddress);
            this.Controls.Add(this.gpbSetCurAddress);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.gpbSetCurAddress.ResumeLayout(false);
            this.gpbSetCurAddress.PerformLayout();
            this.gpbCurrentAddress.ResumeLayout(false);
            this.gpbCurrentAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbSetCurAddress;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCurNumber;
        private System.Windows.Forms.TextBox txbCurStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCurProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCurTown;
        private System.Windows.Forms.Label lblCurrentAddress;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrevious;
        private System.Windows.Forms.GroupBox gpbCurrentAddress;
        private System.Windows.Forms.Button btnSimulatePrevious;
    }
}