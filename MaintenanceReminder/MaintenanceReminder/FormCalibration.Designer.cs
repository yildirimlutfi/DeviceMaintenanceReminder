namespace MaintenanceReminder
{
    partial class FormCalibration
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
            this.dtpCalibrationDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDeviceTag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPurposeOfUsage = new System.Windows.Forms.TextBox();
            this.tbStructureCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCalibrationNote = new System.Windows.Forms.TextBox();
            this.cbDeviceCode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNextCalibrationTime = new System.Windows.Forms.DateTimePicker();
            this.nupCalibrationPeriod = new System.Windows.Forms.NumericUpDown();
            this.cbDeviceName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new ADGV.AdvancedDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCalibrationPeriod)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCalibrationDate
            // 
            this.dtpCalibrationDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpCalibrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpCalibrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCalibrationDate.Location = new System.Drawing.Point(216, 281);
            this.dtpCalibrationDate.Name = "dtpCalibrationDate";
            this.dtpCalibrationDate.Size = new System.Drawing.Size(244, 22);
            this.dtpCalibrationDate.TabIndex = 5;
            this.dtpCalibrationDate.ValueChanged += new System.EventHandler(this.mtbCalibrationPeriod_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(16, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cihaz Künyesi";
            // 
            // tbDeviceTag
            // 
            this.tbDeviceTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDeviceTag.Enabled = false;
            this.tbDeviceTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbDeviceTag.Location = new System.Drawing.Point(216, 231);
            this.tbDeviceTag.Name = "tbDeviceTag";
            this.tbDeviceTag.Size = new System.Drawing.Size(244, 22);
            this.tbDeviceTag.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(16, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kalibrasyon Zamanı";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUpdate.Location = new System.Drawing.Point(216, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(244, 44);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(16, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kalibrasyon Periyodu (Ay)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(16, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kalibrasyon Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kullanım Amacı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cihaz Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(16, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bina Kodu";
            // 
            // tbPurposeOfUsage
            // 
            this.tbPurposeOfUsage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPurposeOfUsage.Enabled = false;
            this.tbPurposeOfUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPurposeOfUsage.Location = new System.Drawing.Point(216, 131);
            this.tbPurposeOfUsage.Name = "tbPurposeOfUsage";
            this.tbPurposeOfUsage.Size = new System.Drawing.Size(244, 22);
            this.tbPurposeOfUsage.TabIndex = 2;
            // 
            // tbStructureCode
            // 
            this.tbStructureCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStructureCode.Enabled = false;
            this.tbStructureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbStructureCode.Location = new System.Drawing.Point(216, 181);
            this.tbStructureCode.Name = "tbStructureCode";
            this.tbStructureCode.Size = new System.Drawing.Size(244, 22);
            this.tbStructureCode.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(16, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kalibrasyon Notu";
            // 
            // tbCalibrationNote
            // 
            this.tbCalibrationNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCalibrationNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCalibrationNote.Location = new System.Drawing.Point(216, 431);
            this.tbCalibrationNote.Multiline = true;
            this.tbCalibrationNote.Name = "tbCalibrationNote";
            this.tbCalibrationNote.Size = new System.Drawing.Size(244, 194);
            this.tbCalibrationNote.TabIndex = 8;
            // 
            // cbDeviceCode
            // 
            this.cbDeviceCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDeviceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbDeviceCode.FormattingEnabled = true;
            this.cbDeviceCode.Location = new System.Drawing.Point(216, 31);
            this.cbDeviceCode.Name = "cbDeviceCode";
            this.cbDeviceCode.Size = new System.Drawing.Size(244, 24);
            this.cbDeviceCode.TabIndex = 0;
            this.cbDeviceCode.SelectedIndexChanged += new System.EventHandler(this.cbDeviceCode_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbDeviceCode, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPurposeOfUsage, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbCalibrationNote, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbStructureCode, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpCalibrationDate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.dtpNextCalibrationTime, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbDeviceTag, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.nupCalibrationPeriod, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbDeviceName, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 706);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(16, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cihaz Adı";
            // 
            // dtpNextCalibrationTime
            // 
            this.dtpNextCalibrationTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNextCalibrationTime.Enabled = false;
            this.dtpNextCalibrationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNextCalibrationTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextCalibrationTime.Location = new System.Drawing.Point(216, 381);
            this.dtpNextCalibrationTime.Name = "dtpNextCalibrationTime";
            this.dtpNextCalibrationTime.Size = new System.Drawing.Size(244, 22);
            this.dtpNextCalibrationTime.TabIndex = 7;
            // 
            // nupCalibrationPeriod
            // 
            this.nupCalibrationPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.nupCalibrationPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nupCalibrationPeriod.Location = new System.Drawing.Point(216, 331);
            this.nupCalibrationPeriod.Name = "nupCalibrationPeriod";
            this.nupCalibrationPeriod.Size = new System.Drawing.Size(244, 22);
            this.nupCalibrationPeriod.TabIndex = 6;
            this.nupCalibrationPeriod.ValueChanged += new System.EventHandler(this.mtbCalibrationPeriod_TextChanged);
            // 
            // cbDeviceName
            // 
            this.cbDeviceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDeviceName.FormattingEnabled = true;
            this.cbDeviceName.Location = new System.Drawing.Point(216, 81);
            this.cbDeviceName.Name = "cbDeviceName";
            this.cbDeviceName.Size = new System.Drawing.Size(244, 21);
            this.cbDeviceName.TabIndex = 35;
            this.cbDeviceName.SelectedIndexChanged += new System.EventHandler(this.cbDeviceCode_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1208, 712);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(486, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(719, 706);
            this.tableLayoutPanel3.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(713, 50);
            this.label10.TabIndex = 36;
            this.label10.Text = "Güncel Kalibrasyon Listesi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateContextFilters = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DateWithTime = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 650);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.TimeFilter = false;
            // 
            // FormCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 712);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalibration";
            this.Text = "FormCalibration";
            this.Load += new System.EventHandler(this.FormCalibration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCalibrationPeriod)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCalibrationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDeviceTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPurposeOfUsage;
        private System.Windows.Forms.TextBox tbStructureCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCalibrationNote;
        private System.Windows.Forms.ComboBox cbDeviceCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNextCalibrationTime;
        private System.Windows.Forms.NumericUpDown nupCalibrationPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDeviceName;
        private ADGV.AdvancedDataGridView dataGridView1;
    }
}