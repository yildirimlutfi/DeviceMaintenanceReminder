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
            this.label11 = new System.Windows.Forms.Label();
            this.tbNumberOfCertificate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCalibrationCompany = new System.Windows.Forms.TextBox();
            this.lbFileList = new System.Windows.Forms.ListBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new ADGV.AdvancedDataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCalibrationPeriod)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCalibrationDate
            // 
            this.dtpCalibrationDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpCalibrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpCalibrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCalibrationDate.Location = new System.Drawing.Point(185, 253);
            this.dtpCalibrationDate.Name = "dtpCalibrationDate";
            this.dtpCalibrationDate.Size = new System.Drawing.Size(169, 22);
            this.dtpCalibrationDate.TabIndex = 5;
            this.dtpCalibrationDate.ValueChanged += new System.EventHandler(this.mtbCalibrationPeriod_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(10, 200);
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
            this.tbDeviceTag.Location = new System.Drawing.Point(185, 203);
            this.tbDeviceTag.Name = "tbDeviceTag";
            this.tbDeviceTag.Size = new System.Drawing.Size(169, 22);
            this.tbDeviceTag.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(10, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kalibrasyon Zamanı";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 50);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Bilgileri\r\nGüncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(10, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kalibrasyon Periyodu (Ay)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kalibrasyon Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kullanım Amacı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cihaz Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 150);
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
            this.tbPurposeOfUsage.Location = new System.Drawing.Point(185, 103);
            this.tbPurposeOfUsage.Name = "tbPurposeOfUsage";
            this.tbPurposeOfUsage.Size = new System.Drawing.Size(169, 22);
            this.tbPurposeOfUsage.TabIndex = 2;
            // 
            // tbStructureCode
            // 
            this.tbStructureCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStructureCode.Enabled = false;
            this.tbStructureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbStructureCode.Location = new System.Drawing.Point(185, 153);
            this.tbStructureCode.Name = "tbStructureCode";
            this.tbStructureCode.Size = new System.Drawing.Size(169, 22);
            this.tbStructureCode.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(10, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kalibrasyon Notu";
            // 
            // tbCalibrationNote
            // 
            this.tbCalibrationNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCalibrationNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCalibrationNote.Location = new System.Drawing.Point(185, 503);
            this.tbCalibrationNote.Multiline = true;
            this.tbCalibrationNote.Name = "tbCalibrationNote";
            this.tbCalibrationNote.Size = new System.Drawing.Size(169, 74);
            this.tbCalibrationNote.TabIndex = 10;
            // 
            // cbDeviceCode
            // 
            this.cbDeviceCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDeviceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbDeviceCode.FormattingEnabled = true;
            this.cbDeviceCode.Location = new System.Drawing.Point(185, 3);
            this.cbDeviceCode.Name = "cbDeviceCode";
            this.cbDeviceCode.Size = new System.Drawing.Size(169, 24);
            this.cbDeviceCode.TabIndex = 0;
            this.cbDeviceCode.SelectedIndexChanged += new System.EventHandler(this.cbDeviceCode_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbDeviceCode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPurposeOfUsage, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbStructureCode, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpCalibrationDate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpNextCalibrationTime, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbDeviceTag, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.nupCalibrationPeriod, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbDeviceName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbNumberOfCertificate, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbCalibrationNote, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbCalibrationCompany, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 746);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(10, 50);
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
            this.dtpNextCalibrationTime.Location = new System.Drawing.Point(185, 353);
            this.dtpNextCalibrationTime.Name = "dtpNextCalibrationTime";
            this.dtpNextCalibrationTime.Size = new System.Drawing.Size(169, 22);
            this.dtpNextCalibrationTime.TabIndex = 7;
            // 
            // nupCalibrationPeriod
            // 
            this.nupCalibrationPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.nupCalibrationPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nupCalibrationPeriod.Location = new System.Drawing.Point(185, 303);
            this.nupCalibrationPeriod.Name = "nupCalibrationPeriod";
            this.nupCalibrationPeriod.Size = new System.Drawing.Size(169, 22);
            this.nupCalibrationPeriod.TabIndex = 6;
            this.nupCalibrationPeriod.ValueChanged += new System.EventHandler(this.mtbCalibrationPeriod_TextChanged);
            // 
            // cbDeviceName
            // 
            this.cbDeviceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDeviceName.FormattingEnabled = true;
            this.cbDeviceName.Location = new System.Drawing.Point(185, 53);
            this.cbDeviceName.Name = "cbDeviceName";
            this.cbDeviceName.Size = new System.Drawing.Size(169, 21);
            this.cbDeviceName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(10, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Sertifika Numarası";
            // 
            // tbNumberOfCertificate
            // 
            this.tbNumberOfCertificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNumberOfCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbNumberOfCertificate.Location = new System.Drawing.Point(185, 453);
            this.tbNumberOfCertificate.Name = "tbNumberOfCertificate";
            this.tbNumberOfCertificate.Size = new System.Drawing.Size(169, 22);
            this.tbNumberOfCertificate.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(10, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Kalibrasyon Firması";
            // 
            // tbCalibrationCompany
            // 
            this.tbCalibrationCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCalibrationCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCalibrationCompany.Location = new System.Drawing.Point(185, 403);
            this.tbCalibrationCompany.Name = "tbCalibrationCompany";
            this.tbCalibrationCompany.Size = new System.Drawing.Size(169, 22);
            this.tbCalibrationCompany.TabIndex = 8;
            // 
            // lbFileList
            // 
            this.lbFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileList.FormattingEnabled = true;
            this.lbFileList.Location = new System.Drawing.Point(0, 50);
            this.lbFileList.Margin = new System.Windows.Forms.Padding(0);
            this.lbFileList.Name = "lbFileList";
            this.lbFileList.ScrollAlwaysVisible = true;
            this.lbFileList.Size = new System.Drawing.Size(169, 110);
            this.lbFileList.TabIndex = 43;
            this.lbFileList.DoubleClick += new System.EventHandler(this.lbFileList_DoubleClick);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.White;
            this.btnUploadFile.Location = new System.Drawing.Point(0, 0);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(169, 50);
            this.btnUploadFile.TabIndex = 11;
            this.btnUploadFile.Text = "Dosya Ekle";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1234, 752);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(373, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(858, 746);
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
            this.label10.Size = new System.Drawing.Size(852, 50);
            this.label10.TabIndex = 36;
            this.label10.Text = "Güncel Kalibrasyon Listesi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateContextFilters = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DateWithTime = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 690);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.TimeFilter = false;
            this.dataGridView1.SortStringChanged += new System.EventHandler(this.dataGridView1_SortStringChanged);
            this.dataGridView1.FilterStringChanged += new System.EventHandler(this.dataGridView1_FilterStringChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbFileList, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnUploadFile, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 583);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(169, 160);
            this.tableLayoutPanel4.TabIndex = 44;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnUpdate, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(185, 583);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(169, 160);
            this.tableLayoutPanel5.TabIndex = 45;
            // 
            // FormCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 752);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalibration";
            this.Text = "t";
            this.Load += new System.EventHandler(this.FormCalibration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCalibrationPeriod)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNumberOfCertificate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCalibrationCompany;
        private System.Windows.Forms.Button btnUploadFile;
        private ADGV.AdvancedDataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbFileList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}