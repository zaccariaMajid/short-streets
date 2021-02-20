
namespace PCTO
{
    partial class FormRiderSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiderSpace));
            this.btnConfirmNumPackages = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbQuantity = new System.Windows.Forms.GroupBox();
            this.nudPackages = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSetPackages = new System.Windows.Forms.DataGridView();
            this.btnConfirmPackages = new System.Windows.Forms.Button();
            this.gpbEdit = new System.Windows.Forms.GroupBox();
            this.txbRoad = new System.Windows.Forms.TextBox();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbProvince = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTown = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.gpbQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetPackages)).BeginInit();
            this.gpbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmNumPackages
            // 
            this.btnConfirmNumPackages.Location = new System.Drawing.Point(150, 22);
            this.btnConfirmNumPackages.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmNumPackages.Name = "btnConfirmNumPackages";
            this.btnConfirmNumPackages.Size = new System.Drawing.Size(111, 27);
            this.btnConfirmNumPackages.TabIndex = 2;
            this.btnConfirmNumPackages.Text = "OK";
            this.btnConfirmNumPackages.UseVisualStyleBackColor = true;
            this.btnConfirmNumPackages.Click += new System.EventHandler(this.btnConfirmNumPackages_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "RIDER SPACE";
            // 
            // gpbQuantity
            // 
            this.gpbQuantity.Controls.Add(this.nudPackages);
            this.gpbQuantity.Controls.Add(this.btnConfirmNumPackages);
            this.gpbQuantity.Location = new System.Drawing.Point(35, 59);
            this.gpbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.gpbQuantity.Name = "gpbQuantity";
            this.gpbQuantity.Padding = new System.Windows.Forms.Padding(4);
            this.gpbQuantity.Size = new System.Drawing.Size(281, 66);
            this.gpbQuantity.TabIndex = 4;
            this.gpbQuantity.TabStop = false;
            this.gpbQuantity.Text = "Set packages quantity";
            // 
            // nudPackages
            // 
            this.nudPackages.Location = new System.Drawing.Point(20, 25);
            this.nudPackages.Margin = new System.Windows.Forms.Padding(4);
            this.nudPackages.Name = "nudPackages";
            this.nudPackages.Size = new System.Drawing.Size(122, 22);
            this.nudPackages.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(878, 478);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "CALCOLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 478);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // dgvSetPackages
            // 
            this.dgvSetPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetPackages.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSetPackages.Location = new System.Drawing.Point(34, 133);
            this.dgvSetPackages.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSetPackages.Name = "dgvSetPackages";
            this.dgvSetPackages.RowHeadersWidth = 70;
            this.dgvSetPackages.Size = new System.Drawing.Size(1030, 200);
            this.dgvSetPackages.TabIndex = 7;
            this.dgvSetPackages.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSetPackages_CellEnter);
            this.dgvSetPackages.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSetPackages_CellValueChanged);
            this.dgvSetPackages.SelectionChanged += new System.EventHandler(this.dgvSetPackages_SelectionChanged);
            // 
            // btnConfirmPackages
            // 
            this.btnConfirmPackages.Location = new System.Drawing.Point(902, 349);
            this.btnConfirmPackages.Name = "btnConfirmPackages";
            this.btnConfirmPackages.Size = new System.Drawing.Size(162, 43);
            this.btnConfirmPackages.TabIndex = 8;
            this.btnConfirmPackages.Text = "CONFIRM";
            this.btnConfirmPackages.UseVisualStyleBackColor = true;
            this.btnConfirmPackages.Click += new System.EventHandler(this.btnConfirmPackages_Click);
            // 
            // gpbEdit
            // 
            this.gpbEdit.Controls.Add(this.btnEditPackage);
            this.gpbEdit.Controls.Add(this.txbRoad);
            this.gpbEdit.Controls.Add(this.txbNumber);
            this.gpbEdit.Controls.Add(this.label10);
            this.gpbEdit.Controls.Add(this.label9);
            this.gpbEdit.Controls.Add(this.txbProvince);
            this.gpbEdit.Controls.Add(this.label8);
            this.gpbEdit.Controls.Add(this.txbTown);
            this.gpbEdit.Controls.Add(this.label7);
            this.gpbEdit.Controls.Add(this.label6);
            this.gpbEdit.Controls.Add(this.txbWeight);
            this.gpbEdit.Controls.Add(this.label5);
            this.gpbEdit.Controls.Add(this.label4);
            this.gpbEdit.Controls.Add(this.txbVolume);
            this.gpbEdit.Controls.Add(this.label1);
            this.gpbEdit.Controls.Add(this.lblId);
            this.gpbEdit.Enabled = false;
            this.gpbEdit.Location = new System.Drawing.Point(35, 342);
            this.gpbEdit.Name = "gpbEdit";
            this.gpbEdit.Size = new System.Drawing.Size(470, 232);
            this.gpbEdit.TabIndex = 9;
            this.gpbEdit.TabStop = false;
            this.gpbEdit.Text = "Edit package\'s data";
            // 
            // txbRoad
            // 
            this.txbRoad.Location = new System.Drawing.Point(83, 146);
            this.txbRoad.Name = "txbRoad";
            this.txbRoad.Size = new System.Drawing.Size(198, 22);
            this.txbRoad.TabIndex = 14;
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(373, 146);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(72, 22);
            this.txbNumber.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Road:";
            // 
            // txbProvince
            // 
            this.txbProvince.Location = new System.Drawing.Point(373, 101);
            this.txbProvince.Name = "txbProvince";
            this.txbProvince.Size = new System.Drawing.Size(72, 22);
            this.txbProvince.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Province:";
            // 
            // txbTown
            // 
            this.txbTown.Location = new System.Drawing.Point(83, 101);
            this.txbTown.Name = "txbTown";
            this.txbTown.Size = new System.Drawing.Size(198, 22);
            this.txbTown.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Town:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "m³";
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(326, 55);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(88, 22);
            this.txbWeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kg";
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(83, 55);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(88, 22);
            this.txbVolume.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id: ";
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(180, 191);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(100, 26);
            this.btnEditPackage.TabIndex = 15;
            this.btnEditPackage.Text = "EDIT";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // FormRiderSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 596);
            this.Controls.Add(this.gpbEdit);
            this.Controls.Add(this.btnConfirmPackages);
            this.Controls.Add(this.dgvSetPackages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gpbQuantity);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRiderSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Streets";
            this.gpbQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetPackages)).EndInit();
            this.gpbEdit.ResumeLayout(false);
            this.gpbEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmNumPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbQuantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPackages;
        private System.Windows.Forms.DataGridView dgvSetPackages;
        private System.Windows.Forms.Button btnConfirmPackages;
        private System.Windows.Forms.GroupBox gpbEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbRoad;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbProvince;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditPackage;
    }
}

