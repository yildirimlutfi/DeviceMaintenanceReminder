namespace MaintenanceReminder
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.FormAddDevice = new System.Windows.Forms.Button();
            this.FormCalibration = new System.Windows.Forms.Button();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.FormDevicesList = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.48572F));
            this.tableLayoutPanel1.Controls.Add(this.tlpButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 1;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Controls.Add(this.FormAddDevice, 0, 0);
            this.tlpButton.Controls.Add(this.FormCalibration, 0, 1);
            this.tlpButton.Controls.Add(this.buttonSendMail, 0, 3);
            this.tlpButton.Controls.Add(this.FormDevicesList, 0, 2);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 3);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 7;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(95, 536);
            this.tlpButton.TabIndex = 1;
            // 
            // FormAddDevice
            // 
            this.FormAddDevice.BackColor = System.Drawing.Color.White;
            this.FormAddDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormAddDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormAddDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormAddDevice.Location = new System.Drawing.Point(3, 3);
            this.FormAddDevice.Name = "FormAddDevice";
            this.FormAddDevice.Size = new System.Drawing.Size(89, 54);
            this.FormAddDevice.TabIndex = 0;
            this.FormAddDevice.Text = "Demirbaş Ekle";
            this.FormAddDevice.UseVisualStyleBackColor = false;
            this.FormAddDevice.Click += new System.EventHandler(this.buttonPageChange_Click);
            // 
            // FormCalibration
            // 
            this.FormCalibration.BackColor = System.Drawing.Color.White;
            this.FormCalibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormCalibration.Location = new System.Drawing.Point(3, 63);
            this.FormCalibration.Name = "FormCalibration";
            this.FormCalibration.Size = new System.Drawing.Size(89, 54);
            this.FormCalibration.TabIndex = 1;
            this.FormCalibration.Text = "Güncel Kalibrasyonlar";
            this.FormCalibration.UseVisualStyleBackColor = false;
            this.FormCalibration.Click += new System.EventHandler(this.buttonPageChange_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.BackColor = System.Drawing.Color.White;
            this.buttonSendMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSendMail.Location = new System.Drawing.Point(3, 183);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(89, 54);
            this.buttonSendMail.TabIndex = 3;
            this.buttonSendMail.Text = "Mail Gönder";
            this.buttonSendMail.UseVisualStyleBackColor = false;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // FormDevicesList
            // 
            this.FormDevicesList.BackColor = System.Drawing.Color.White;
            this.FormDevicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormDevicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormDevicesList.Location = new System.Drawing.Point(3, 123);
            this.FormDevicesList.Name = "FormDevicesList";
            this.FormDevicesList.Size = new System.Drawing.Size(89, 54);
            this.FormDevicesList.TabIndex = 4;
            this.FormDevicesList.Text = "Kalibrasyon Geçmişi";
            this.FormDevicesList.UseVisualStyleBackColor = false;
            this.FormDevicesList.Click += new System.EventHandler(this.buttonPageChange_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::MaintenanceReminder.Properties.Resources.LogoAssanGroup;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(104, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(854, 536);
            this.panelMain.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 86400000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Bakım Hatırlatıcısı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button FormAddDevice;
        private System.Windows.Forms.Button FormCalibration;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Button FormDevicesList;
        private System.Windows.Forms.Timer timer1;
    }
}

