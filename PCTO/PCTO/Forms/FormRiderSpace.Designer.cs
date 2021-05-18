
namespace PCTO
{
    partial class FormRiderSpace
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
            this.dgvSetPackages = new System.Windows.Forms.DataGridView();
            this.gpbQuantity = new System.Windows.Forms.GroupBox();
            this.btnClearPackages = new System.Windows.Forms.Button();
            this.btnConfirmNumPackages = new System.Windows.Forms.Button();
            this.nudPackages = new System.Windows.Forms.NumericUpDown();
            this.gpbEdit = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbRoad = new System.Windows.Forms.TextBox();
            this.txbProvince = new System.Windows.Forms.TextBox();
            this.txbTown = new System.Windows.Forms.TextBox();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbVolume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnConfirmPackages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPresetQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnGetPresetPackages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetPackages)).BeginInit();
            this.gpbQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackages)).BeginInit();
            this.gpbEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPresetQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSetPackages
            // 
            this.dgvSetPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetPackages.Location = new System.Drawing.Point(12, 87);
            this.dgvSetPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSetPackages.Name = "dgvSetPackages";
            this.dgvSetPackages.RowHeadersWidth = 51;
            this.dgvSetPackages.RowTemplate.Height = 24;
            this.dgvSetPackages.Size = new System.Drawing.Size(1005, 237);
            this.dgvSetPackages.TabIndex = 0;
            this.dgvSetPackages.SelectionChanged += new System.EventHandler(this.dgvSetPackages_SelectionChanged);
            // 
            // gpbQuantity
            // 
            this.gpbQuantity.Controls.Add(this.btnConfirmNumPackages);
            this.gpbQuantity.Controls.Add(this.nudPackages);
            this.gpbQuantity.Location = new System.Drawing.Point(289, 11);
            this.gpbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbQuantity.Name = "gpbQuantity";
            this.gpbQuantity.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbQuantity.Size = new System.Drawing.Size(269, 69);
            this.gpbQuantity.TabIndex = 1;
            this.gpbQuantity.TabStop = false;
            this.gpbQuantity.Text = "Set new packages quantity";
            // 
            // btnClearPackages
            // 
            this.btnClearPackages.Location = new System.Drawing.Point(831, 458);
            this.btnClearPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearPackages.Name = "btnClearPackages";
            this.btnClearPackages.Size = new System.Drawing.Size(186, 33);
            this.btnClearPackages.TabIndex = 2;
            this.btnClearPackages.Text = "CLEAR";
            this.btnClearPackages.UseVisualStyleBackColor = true;
            this.btnClearPackages.Click += new System.EventHandler(this.btnClearPackages_Click);
            // 
            // btnConfirmNumPackages
            // 
            this.btnConfirmNumPackages.Location = new System.Drawing.Point(157, 30);
            this.btnConfirmNumPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmNumPackages.Name = "btnConfirmNumPackages";
            this.btnConfirmNumPackages.Size = new System.Drawing.Size(89, 23);
            this.btnConfirmNumPackages.TabIndex = 1;
            this.btnConfirmNumPackages.Text = "SET";
            this.btnConfirmNumPackages.UseVisualStyleBackColor = true;
            this.btnConfirmNumPackages.Click += new System.EventHandler(this.btnConfirmNumPackages_Click);
            // 
            // nudPackages
            // 
            this.nudPackages.Location = new System.Drawing.Point(29, 31);
            this.nudPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPackages.Name = "nudPackages";
            this.nudPackages.Size = new System.Drawing.Size(107, 22);
            this.nudPackages.TabIndex = 0;
            // 
            // gpbEdit
            // 
            this.gpbEdit.Controls.Add(this.label9);
            this.gpbEdit.Controls.Add(this.label8);
            this.gpbEdit.Controls.Add(this.btnEdit);
            this.gpbEdit.Controls.Add(this.txbNumber);
            this.gpbEdit.Controls.Add(this.txbRoad);
            this.gpbEdit.Controls.Add(this.txbProvince);
            this.gpbEdit.Controls.Add(this.txbTown);
            this.gpbEdit.Controls.Add(this.txbWeight);
            this.gpbEdit.Controls.Add(this.txbVolume);
            this.gpbEdit.Controls.Add(this.label6);
            this.gpbEdit.Controls.Add(this.label5);
            this.gpbEdit.Controls.Add(this.label4);
            this.gpbEdit.Controls.Add(this.label3);
            this.gpbEdit.Controls.Add(this.label2);
            this.gpbEdit.Controls.Add(this.label1);
            this.gpbEdit.Controls.Add(this.lblId);
            this.gpbEdit.Enabled = false;
            this.gpbEdit.Location = new System.Drawing.Point(12, 328);
            this.gpbEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEdit.Name = "gpbEdit";
            this.gpbEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEdit.Size = new System.Drawing.Size(650, 222);
            this.gpbEdit.TabIndex = 2;
            this.gpbEdit.TabStop = false;
            this.gpbEdit.Text = "Edit package\'s properties";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "m³";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(556, 186);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 32);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(343, 130);
            this.txbNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(87, 22);
            this.txbNumber.TabIndex = 12;
            // 
            // txbRoad
            // 
            this.txbRoad.Location = new System.Drawing.Point(77, 130);
            this.txbRoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRoad.Name = "txbRoad";
            this.txbRoad.Size = new System.Drawing.Size(172, 22);
            this.txbRoad.TabIndex = 11;
            // 
            // txbProvince
            // 
            this.txbProvince.Location = new System.Drawing.Point(343, 94);
            this.txbProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProvince.Name = "txbProvince";
            this.txbProvince.Size = new System.Drawing.Size(87, 22);
            this.txbProvince.TabIndex = 10;
            // 
            // txbTown
            // 
            this.txbTown.Location = new System.Drawing.Point(77, 94);
            this.txbTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTown.Name = "txbTown";
            this.txbTown.Size = new System.Drawing.Size(172, 22);
            this.txbTown.TabIndex = 9;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(343, 59);
            this.txbWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(87, 22);
            this.txbWeight.TabIndex = 8;
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(77, 59);
            this.txbVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(87, 22);
            this.txbVolume.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Province:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Town:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // btnConfirmPackages
            // 
            this.btnConfirmPackages.Location = new System.Drawing.Point(831, 498);
            this.btnConfirmPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPackages.Name = "btnConfirmPackages";
            this.btnConfirmPackages.Size = new System.Drawing.Size(186, 52);
            this.btnConfirmPackages.TabIndex = 3;
            this.btnConfirmPackages.Text = "CONFIRM";
            this.btnConfirmPackages.UseVisualStyleBackColor = true;
            this.btnConfirmPackages.Click += new System.EventHandler(this.btnConfirmPackages_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudPresetQuantity);
            this.groupBox1.Controls.Add(this.btnGetPresetPackages);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(271, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import packages";
            // 
            // nudPresetQuantity
            // 
            this.nudPresetQuantity.Location = new System.Drawing.Point(25, 30);
            this.nudPresetQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPresetQuantity.Name = "nudPresetQuantity";
            this.nudPresetQuantity.Size = new System.Drawing.Size(107, 22);
            this.nudPresetQuantity.TabIndex = 6;
            // 
            // btnGetPresetPackages
            // 
            this.btnGetPresetPackages.Location = new System.Drawing.Point(149, 29);
            this.btnGetPresetPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetPresetPackages.Name = "btnGetPresetPackages";
            this.btnGetPresetPackages.Size = new System.Drawing.Size(100, 23);
            this.btnGetPresetPackages.TabIndex = 0;
            this.btnGetPresetPackages.Text = "IMPORT";
            this.btnGetPresetPackages.UseVisualStyleBackColor = true;
            this.btnGetPresetPackages.Click += new System.EventHandler(this.btnGetPresetPackages_Click);
            // 
            // FormRiderSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.btnClearPackages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmPackages);
            this.Controls.Add(this.gpbEdit);
            this.Controls.Add(this.gpbQuantity);
            this.Controls.Add(this.dgvSetPackages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRiderSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rider space";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetPackages)).EndInit();
            this.gpbQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPackages)).EndInit();
            this.gpbEdit.ResumeLayout(false);
            this.gpbEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPresetQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSetPackages;
        private System.Windows.Forms.GroupBox gpbQuantity;
        private System.Windows.Forms.Button btnConfirmNumPackages;
        private System.Windows.Forms.NumericUpDown nudPackages;
        private System.Windows.Forms.GroupBox gpbEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbRoad;
        private System.Windows.Forms.TextBox txbProvince;
        private System.Windows.Forms.TextBox txbTown;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnConfirmPackages;
        private System.Windows.Forms.Button btnClearPackages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPresetQuantity;
        private System.Windows.Forms.Button btnGetPresetPackages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}