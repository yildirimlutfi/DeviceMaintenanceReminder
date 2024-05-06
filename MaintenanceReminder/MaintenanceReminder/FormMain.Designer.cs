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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.FormAddDevice = new System.Windows.Forms.Button();
            this.FormCalibration = new System.Windows.Forms.Button();
            this.FormDevicesList = new System.Windows.Forms.Button();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMail = new System.Windows.Forms.TableLayoutPanel();
            this.tbMail2 = new System.Windows.Forms.TextBox();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.tbMail1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51429F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.48572F));
            this.tlpMain.Controls.Add(this.panelMain, 1, 0);
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1088, 588);
            this.tlpMain.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::MaintenanceReminder.Properties.Resources.FlagOfTurkeyGif_6;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(117, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(968, 582);
            this.panelMain.TabIndex = 2;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Controls.Add(this.tlpButton, 0, 0);
            this.tlpLeft.Controls.Add(this.tlpInfo, 0, 2);
            this.tlpLeft.Controls.Add(this.tlpMail, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 3;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(108, 582);
            this.tlpLeft.TabIndex = 3;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 1;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Controls.Add(this.FormAddDevice, 0, 0);
            this.tlpButton.Controls.Add(this.FormCalibration, 0, 1);
            this.tlpButton.Controls.Add(this.FormDevicesList, 0, 2);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 3);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 3;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.Size = new System.Drawing.Size(102, 194);
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
            this.FormAddDevice.Size = new System.Drawing.Size(96, 58);
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
            this.FormCalibration.Location = new System.Drawing.Point(3, 67);
            this.FormCalibration.Name = "FormCalibration";
            this.FormCalibration.Size = new System.Drawing.Size(96, 58);
            this.FormCalibration.TabIndex = 1;
            this.FormCalibration.Text = "Güncel Kalibrasyonlar";
            this.FormCalibration.UseVisualStyleBackColor = false;
            this.FormCalibration.Click += new System.EventHandler(this.buttonPageChange_Click);
            // 
            // FormDevicesList
            // 
            this.FormDevicesList.BackColor = System.Drawing.Color.White;
            this.FormDevicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormDevicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormDevicesList.Location = new System.Drawing.Point(3, 131);
            this.FormDevicesList.Name = "FormDevicesList";
            this.FormDevicesList.Size = new System.Drawing.Size(96, 60);
            this.FormDevicesList.TabIndex = 4;
            this.FormDevicesList.Text = "Kalibrasyon Geçmişi";
            this.FormDevicesList.UseVisualStyleBackColor = false;
            this.FormDevicesList.Click += new System.EventHandler(this.buttonPageChange_Click);
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 353);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 2;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Size = new System.Drawing.Size(102, 226);
            this.tlpInfo.TabIndex = 2;
            // 
            // tlpMail
            // 
            this.tlpMail.BackColor = System.Drawing.Color.DimGray;
            this.tlpMail.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMail.ColumnCount = 1;
            this.tlpMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMail.Controls.Add(this.tbMail2, 0, 2);
            this.tlpMail.Controls.Add(this.buttonSendMail, 0, 0);
            this.tlpMail.Controls.Add(this.tbMail1, 0, 1);
            this.tlpMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMail.Location = new System.Drawing.Point(2, 202);
            this.tlpMail.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMail.Name = "tlpMail";
            this.tlpMail.RowCount = 3;
            this.tlpMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMail.Size = new System.Drawing.Size(104, 146);
            this.tlpMail.TabIndex = 3;
            // 
            // tbMail2
            // 
            this.tbMail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMail2.Location = new System.Drawing.Point(4, 118);
            this.tbMail2.Multiline = true;
            this.tbMail2.Name = "tbMail2";
            this.tbMail2.Size = new System.Drawing.Size(96, 24);
            this.tbMail2.TabIndex = 5;
            this.tbMail2.Text = "lutfi.yildirim@asp.com.tr";
            this.tbMail2.Validated += new System.EventHandler(this.tbMail1_Validated);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.BackColor = System.Drawing.Color.White;
            this.buttonSendMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSendMail.Location = new System.Drawing.Point(4, 4);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(96, 76);
            this.buttonSendMail.TabIndex = 3;
            this.buttonSendMail.Text = "Mail Adresleri";
            this.buttonSendMail.UseVisualStyleBackColor = false;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // tbMail1
            // 
            this.tbMail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMail1.Location = new System.Drawing.Point(4, 87);
            this.tbMail1.Multiline = true;
            this.tbMail1.Name = "tbMail1";
            this.tbMail1.Size = new System.Drawing.Size(96, 24);
            this.tbMail1.TabIndex = 4;
            this.tbMail1.Text = "lutfi.yildirim@asp.com.tr";
            this.tbMail1.Validated += new System.EventHandler(this.tbMail1_Validated);
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
            this.ClientSize = new System.Drawing.Size(1088, 588);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Bakım Hatırlatıcısı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.tlpMail.ResumeLayout(false);
            this.tlpMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button FormAddDevice;
        private System.Windows.Forms.Button FormCalibration;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Button FormDevicesList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpMail;
        private System.Windows.Forms.TextBox tbMail2;
        private System.Windows.Forms.TextBox tbMail1;
    }
}

