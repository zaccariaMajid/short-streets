
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
            this.label7 = new System.Windows.Forms.Label();
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
            this.dgvSetPackages.Location = new System.Drawing.Point(9, 105);
            this.dgvSetPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSetPackages.Name = "dgvSetPackages";
            this.dgvSetPackages.RowHeadersWidth = 51;
            this.dgvSetPackages.RowTemplate.Height = 24;
            this.dgvSetPackages.Size = new System.Drawing.Size(754, 148);
            this.dgvSetPackages.TabIndex = 0;
            this.dgvSetPackages.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSetPackages_CellEnter);
            this.dgvSetPackages.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSetPackages_CellValueChanged);
            this.dgvSetPackages.SelectionChanged += new System.EventHandler(this.dgvSetPackages_SelectionChanged);
            // 
            // gpbQuantity
            // 
            this.gpbQuantity.Controls.Add(this.btnClearPackages);
            this.gpbQuantity.Controls.Add(this.btnConfirmNumPackages);
            this.gpbQuantity.Controls.Add(this.nudPackages);
            this.gpbQuantity.Location = new System.Drawing.Point(9, 44);
            this.gpbQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbQuantity.Name = "gpbQuantity";
            this.gpbQuantity.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbQuantity.Size = new System.Drawing.Size(292, 56);
            this.gpbQuantity.TabIndex = 1;
            this.gpbQuantity.TabStop = false;
            this.gpbQuantity.Text = "Set packages quantity";
            // 
            // btnClearPackages
            // 
            this.btnClearPackages.Location = new System.Drawing.Point(202, 24);
            this.btnClearPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearPackages.Name = "btnClearPackages";
            this.btnClearPackages.Size = new System.Drawing.Size(67, 19);
            this.btnClearPackages.TabIndex = 2;
            this.btnClearPackages.Text = "CLEAR";
            this.btnClearPackages.UseVisualStyleBackColor = true;
            this.btnClearPackages.Click += new System.EventHandler(this.btnClearPackages_Click);
            // 
            // btnConfirmNumPackages
            // 
            this.btnConfirmNumPackages.Location = new System.Drawing.Point(118, 24);
            this.btnConfirmNumPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmNumPackages.Name = "btnConfirmNumPackages";
            this.btnConfirmNumPackages.Size = new System.Drawing.Size(67, 19);
            this.btnConfirmNumPackages.TabIndex = 1;
            this.btnConfirmNumPackages.Text = "OK";
            this.btnConfirmNumPackages.UseVisualStyleBackColor = true;
            this.btnConfirmNumPackages.Click += new System.EventHandler(this.btnConfirmNumPackages_Click);
            // 
            // nudPackages
            // 
            this.nudPackages.Location = new System.Drawing.Point(22, 25);
            this.nudPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudPackages.Name = "nudPackages";
            this.nudPackages.Size = new System.Drawing.Size(80, 20);
            this.nudPackages.TabIndex = 0;
            // 
            // gpbEdit
            // 
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
            this.gpbEdit.Location = new System.Drawing.Point(170, 266);
            this.gpbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbEdit.Name = "gpbEdit";
            this.gpbEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbEdit.Size = new System.Drawing.Size(366, 180);
            this.gpbEdit.TabIndex = 2;
            this.gpbEdit.TabStop = false;
            this.gpbEdit.Text = "Edit package\'s properties";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(150, 140);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 26);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(257, 106);
            this.txbNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(76, 20);
            this.txbNumber.TabIndex = 12;
            // 
            // txbRoad
            // 
            this.txbRoad.Location = new System.Drawing.Point(58, 106);
            this.txbRoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbRoad.Name = "txbRoad";
            this.txbRoad.Size = new System.Drawing.Size(130, 20);
            this.txbRoad.TabIndex = 11;
            // 
            // txbProvince
            // 
            this.txbProvince.Location = new System.Drawing.Point(257, 76);
            this.txbProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbProvince.Name = "txbProvince";
            this.txbProvince.Size = new System.Drawing.Size(76, 20);
            this.txbProvince.TabIndex = 10;
            // 
            // txbTown
            // 
            this.txbTown.Location = new System.Drawing.Point(58, 76);
            this.txbTown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTown.Name = "txbTown";
            this.txbTown.Size = new System.Drawing.Size(130, 20);
            this.txbTown.TabIndex = 9;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(257, 48);
            this.txbWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(66, 20);
            this.txbWeight.TabIndex = 8;
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(58, 48);
            this.txbVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(66, 20);
            this.txbVolume.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Road:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Province:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Town:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 24);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // btnConfirmPackages
            // 
            this.btnConfirmPackages.Location = new System.Drawing.Point(656, 266);
            this.btnConfirmPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmPackages.Name = "btnConfirmPackages";
            this.btnConfirmPackages.Size = new System.Drawing.Size(107, 27);
            this.btnConfirmPackages.TabIndex = 3;
            this.btnConfirmPackages.Text = "CONFIRM";
            this.btnConfirmPackages.UseVisualStyleBackColor = true;
            this.btnConfirmPackages.Click += new System.EventHandler(this.btnConfirmPackages_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "RIDER SPACE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudPresetQuantity);
            this.groupBox1.Controls.Add(this.btnGetPresetPackages);
            this.groupBox1.Location = new System.Drawing.Point(560, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(203, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get pre-set packages";
            // 
            // nudPresetQuantity
            // 
            this.nudPresetQuantity.Location = new System.Drawing.Point(28, 26);
            this.nudPresetQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudPresetQuantity.Name = "nudPresetQuantity";
            this.nudPresetQuantity.Size = new System.Drawing.Size(80, 20);
            this.nudPresetQuantity.TabIndex = 6;
            // 
            // btnGetPresetPackages
            // 
            this.btnGetPresetPackages.Location = new System.Drawing.Point(122, 25);
            this.btnGetPresetPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetPresetPackages.Name = "btnGetPresetPackages";
            this.btnGetPresetPackages.Size = new System.Drawing.Size(67, 19);
            this.btnGetPresetPackages.TabIndex = 0;
            this.btnGetPresetPackages.Text = "GET";
            this.btnGetPresetPackages.UseVisualStyleBackColor = true;
            this.btnGetPresetPackages.Click += new System.EventHandler(this.btnGetPresetPackages_Click);
            // 
            // FormRiderSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConfirmPackages);
            this.Controls.Add(this.gpbEdit);
            this.Controls.Add(this.gpbQuantity);
            this.Controls.Add(this.dgvSetPackages);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearPackages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPresetQuantity;
        private System.Windows.Forms.Button btnGetPresetPackages;
    }
}