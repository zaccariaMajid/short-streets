
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
            this.btnRiderSpace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSetRange = new System.Windows.Forms.Button();
            this.gpbSetCurAddress.SuspendLayout();
            this.gpbCurrentAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.gpbSetCurAddress.Location = new System.Drawing.Point(12, 12);
            this.gpbSetCurAddress.Name = "gpbSetCurAddress";
            this.gpbSetCurAddress.Size = new System.Drawing.Size(1005, 144);
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
            this.btnConfirm.Location = new System.Drawing.Point(862, 89);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(137, 46);
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
            this.btnChange.Location = new System.Drawing.Point(862, 106);
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
            this.lblCurrentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAddress.Location = new System.Drawing.Point(19, 60);
            this.lblCurrentAddress.Name = "lblCurrentAddress";
            this.lblCurrentAddress.Size = new System.Drawing.Size(9, 20);
            this.lblCurrentAddress.TabIndex = 1;
            this.lblCurrentAddress.Text = "\r\n";
            // 
            // gpbCurrentAddress
            // 
            this.gpbCurrentAddress.Controls.Add(this.btnRiderSpace);
            this.gpbCurrentAddress.Controls.Add(this.lblCurrentAddress);
            this.gpbCurrentAddress.Controls.Add(this.btnChange);
            this.gpbCurrentAddress.Enabled = false;
            this.gpbCurrentAddress.Location = new System.Drawing.Point(12, 173);
            this.gpbCurrentAddress.Name = "gpbCurrentAddress";
            this.gpbCurrentAddress.Size = new System.Drawing.Size(1005, 140);
            this.gpbCurrentAddress.TabIndex = 3;
            this.gpbCurrentAddress.TabStop = false;
            // 
            // btnRiderSpace
            // 
            this.btnRiderSpace.Location = new System.Drawing.Point(862, 54);
            this.btnRiderSpace.Name = "btnRiderSpace";
            this.btnRiderSpace.Size = new System.Drawing.Size(137, 46);
            this.btnRiderSpace.TabIndex = 3;
            this.btnRiderSpace.Text = "RIDER SPACE";
            this.btnRiderSpace.UseVisualStyleBackColor = true;
            this.btnRiderSpace.Click += new System.EventHandler(this.btnRiderSpace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetRange);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 213);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set coordinates range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Latitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Longitude";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Min coordinates";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(293, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Max coordinates";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Latitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Longitude";
            // 
            // btnSetRange
            // 
            this.btnSetRange.Location = new System.Drawing.Point(862, 120);
            this.btnSetRange.Name = "btnSetRange";
            this.btnSetRange.Size = new System.Drawing.Size(137, 46);
            this.btnSetRange.TabIndex = 4;
            this.btnSetRange.Text = "SET RANGE";
            this.btnSetRange.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbCurrentAddress);
            this.Controls.Add(this.gpbSetCurAddress);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.gpbSetCurAddress.ResumeLayout(false);
            this.gpbSetCurAddress.PerformLayout();
            this.gpbCurrentAddress.ResumeLayout(false);
            this.gpbCurrentAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnRiderSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetRange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}