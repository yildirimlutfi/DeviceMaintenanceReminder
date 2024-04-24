using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Threading;
using System.Reflection;
using MaintenanceReminder;

namespace MaintenanceReminder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static Button btnPassedCalibrations =new Button();
        static Button btnNearestCalibrations = new Button();

        public static void ClearDeviceData()
        {
            ClassGv.DeviceList.Date.Clear();
            ClassGv.DeviceList.DeviceCode.Clear();
            ClassGv.DeviceList.DeviceName.Clear();
            ClassGv.DeviceList.PurposeOfUsage.Clear();
            ClassGv.DeviceList.StructureCode.Clear();
            ClassGv.DeviceList.DeviceTag.Clear();
            ClassGv.DeviceList.CalibrationRequired.Clear();
        }

        public static void ClearCalibrationHistoryData()
        {
            ClassGv.CalibrationHistoryList.Date.Clear();
            ClassGv.CalibrationHistoryList.Time.Clear();
            ClassGv.CalibrationHistoryList.DeviceCode.Clear();
            ClassGv.CalibrationHistoryList.DeviceName.Clear();
            ClassGv.CalibrationHistoryList.PurposeOfUsage.Clear();
            ClassGv.CalibrationHistoryList.StructureCode.Clear();
            ClassGv.CalibrationHistoryList.DeviceTag.Clear();
            ClassGv.CalibrationHistoryList.CalibrationDate.Clear();
            ClassGv.CalibrationHistoryList.CalibrationPeriod.Clear();
            ClassGv.CalibrationHistoryList.NextCalibrationDate.Clear();
            ClassGv.CalibrationHistoryList.CalibrationNote.Clear();
        }

        public static void ClearActiveCalibrationData()
        {
            ClassGv.ActiveCalibrationList.Date.Clear();
            ClassGv.ActiveCalibrationList.Time.Clear();
            ClassGv.ActiveCalibrationList.DeviceCode.Clear();
            ClassGv.ActiveCalibrationList.DeviceName.Clear();
            ClassGv.ActiveCalibrationList.PurposeOfUsage.Clear();
            ClassGv.ActiveCalibrationList.StructureCode.Clear();
            ClassGv.ActiveCalibrationList.DeviceTag.Clear();
            ClassGv.ActiveCalibrationList.CalibrationDate.Clear();
            ClassGv.ActiveCalibrationList.CalibrationPeriod.Clear();
            ClassGv.ActiveCalibrationList.NextCalibrationDate.Clear();
            ClassGv.ActiveCalibrationList.CalibrationNote.Clear();
        }

        public static void ClearNearestAndPassedCalibration()
        {
            ClassGv.NearestCalibration.Date.Clear();
            ClassGv.NearestCalibration.Time.Clear();
            ClassGv.NearestCalibration.DeviceCode.Clear();
            ClassGv.NearestCalibration.DeviceName.Clear();
            ClassGv.NearestCalibration.PurposeOfUsage.Clear();
            ClassGv.NearestCalibration.StructureCode.Clear();
            ClassGv.NearestCalibration.DeviceTag.Clear();
            ClassGv.NearestCalibration.CalibrationDate.Clear();
            ClassGv.NearestCalibration.CalibrationPeriod.Clear();
            ClassGv.NearestCalibration.NextCalibrationDate.Clear();
            ClassGv.NearestCalibration.CalibrationNote.Clear();

            ClassGv.PassedCalibration.Date.Clear();
            ClassGv.PassedCalibration.Time.Clear();
            ClassGv.PassedCalibration.DeviceCode.Clear();
            ClassGv.PassedCalibration.DeviceName.Clear();
            ClassGv.PassedCalibration.PurposeOfUsage.Clear();
            ClassGv.PassedCalibration.StructureCode.Clear();
            ClassGv.PassedCalibration.DeviceTag.Clear();
            ClassGv.PassedCalibration.CalibrationDate.Clear();
            ClassGv.PassedCalibration.CalibrationPeriod.Clear();
            ClassGv.PassedCalibration.NextCalibrationDate.Clear();
            ClassGv.PassedCalibration.CalibrationNote.Clear();
        }

        public static void GetDeviceList()
        {
            ClearDeviceData();
            ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\DeviceList.txt";
            ClassTxt.FileCreate();

            string[] temp = ClassTxt.Read().Split(';');
            for (int i = 0; i < temp.Length - 1; i = i + 8)
            {
                ClassGv.DeviceList.Date.Add(temp[i + 0]);
                ClassGv.DeviceList.Time.Add(temp[i + 1]);
                ClassGv.DeviceList.DeviceCode.Add(temp[i + 2]);
                ClassGv.DeviceList.DeviceName.Add(temp[i + 3]);
                ClassGv.DeviceList.PurposeOfUsage.Add(temp[i + 4]);
                ClassGv.DeviceList.StructureCode.Add(temp[i + 5]);
                ClassGv.DeviceList.DeviceTag.Add(temp[i + 6]);
                ClassGv.DeviceList.CalibrationRequired.Add(temp[i + 7]);
            }
        }

        public static void GetCalibrationHistoryList()
        {
            ClearCalibrationHistoryData();
            ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\CalibrationHistoryList.txt";
            ClassTxt.FileCreate();

            string[] temp = ClassTxt.Read().Split(';');
            for (int i = 0; i < temp.Length - 1; i = i + 11)
            {
                ClassGv.CalibrationHistoryList.Date.Add(temp[i + 0]);
                ClassGv.CalibrationHistoryList.Time.Add(temp[i + 1]);
                ClassGv.CalibrationHistoryList.DeviceCode.Add(temp[i + 2]);
                ClassGv.CalibrationHistoryList.DeviceName.Add(temp[i + 3]);
                ClassGv.CalibrationHistoryList.PurposeOfUsage.Add(temp[i + 4]);
                ClassGv.CalibrationHistoryList.StructureCode.Add(temp[i + 5]);
                ClassGv.CalibrationHistoryList.DeviceTag.Add(temp[i + 6]);
                ClassGv.CalibrationHistoryList.CalibrationDate.Add(temp[i + 7]);
                ClassGv.CalibrationHistoryList.CalibrationPeriod.Add(temp[i + 8]);
                ClassGv.CalibrationHistoryList.NextCalibrationDate.Add(temp[i + 9]);
                ClassGv.CalibrationHistoryList.CalibrationNote.Add(temp[i + 10]);
            }
        }

        public static void GetActiveCalibrationList()
        {
            ClearActiveCalibrationData();
            ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\ActiveCalibrationList.txt";
            ClassTxt.FileCreate();

            string[] temp = ClassTxt.Read().Split(';');
            for (int i = 0; i < temp.Length - 1; i = i + 11)
            {
                ClassGv.ActiveCalibrationList.Date.Add(temp[i + 0]);
                ClassGv.ActiveCalibrationList.Time.Add(temp[i + 1]);
                ClassGv.ActiveCalibrationList.DeviceCode.Add(temp[i + 2]);
                ClassGv.ActiveCalibrationList.DeviceName.Add(temp[i + 3]);
                ClassGv.ActiveCalibrationList.PurposeOfUsage.Add(temp[i + 4]);
                ClassGv.ActiveCalibrationList.StructureCode.Add(temp[i + 5]);
                ClassGv.ActiveCalibrationList.DeviceTag.Add(temp[i + 6]);
                ClassGv.ActiveCalibrationList.CalibrationDate.Add(temp[i + 7]);
                ClassGv.ActiveCalibrationList.CalibrationPeriod.Add(temp[i + 8]);
                ClassGv.ActiveCalibrationList.NextCalibrationDate.Add(temp[i + 9]);
                ClassGv.ActiveCalibrationList.CalibrationNote.Add(temp[i + 10]);
            }
        }

        public static void CalculateNearestAndPassedCalibration()
        {
            btnPassedCalibrations.Text ="Geçmiş Kalibrasyon Yok";
            btnPassedCalibrations.BackColor = Color.White;
            btnNearestCalibrations.Text = "Yaklaşan Kalibrasyon Yok";
            btnNearestCalibrations.BackColor = Color.White;


            for (int i = 0; i < ClassGv.ActiveCalibrationList.NextCalibrationDate.Count; i++)
            {
                TimeSpan timeSpan = Convert.ToDateTime(ClassGv.ActiveCalibrationList.NextCalibrationDate[i]) - DateTime.Now.Date;
                TimeSpan remainingTime = new TimeSpan(ClassGv.MailAlertRemainingTime, 0, 0, 0, 0);
                if (timeSpan < TimeSpan.Zero)
                {
                    if (btnPassedCalibrations.Text.Length < 25)
                    {
                        btnPassedCalibrations.Text = "Geçmiş Kalibrasyon;       \n";
                    }
                    btnPassedCalibrations.Text += ClassGv.ActiveCalibrationList.DeviceCode[i] + ", \n";
                    btnPassedCalibrations.BackColor = Color.Red;

                    ClassGv.PassedCalibration.Date.Add(ClassGv.ActiveCalibrationList.Date[i]);
                    ClassGv.PassedCalibration.Time.Add(ClassGv.ActiveCalibrationList.Time[i]);
                    ClassGv.PassedCalibration.DeviceCode.Add(ClassGv.ActiveCalibrationList.DeviceCode[i]);
                    ClassGv.PassedCalibration.DeviceName.Add(ClassGv.ActiveCalibrationList.DeviceName[i]);
                    ClassGv.PassedCalibration.PurposeOfUsage.Add(ClassGv.ActiveCalibrationList.PurposeOfUsage[i]);
                    ClassGv.PassedCalibration.StructureCode.Add(ClassGv.ActiveCalibrationList.StructureCode[i]);
                    ClassGv.PassedCalibration.DeviceTag.Add(ClassGv.ActiveCalibrationList.DeviceTag[i]);
                    ClassGv.PassedCalibration.CalibrationDate.Add(ClassGv.ActiveCalibrationList.CalibrationDate[i]);
                    ClassGv.PassedCalibration.CalibrationPeriod.Add(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                    ClassGv.PassedCalibration.NextCalibrationDate.Add(ClassGv.ActiveCalibrationList.NextCalibrationDate[i]);
                    ClassGv.PassedCalibration.CalibrationNote.Add(ClassGv.ActiveCalibrationList.CalibrationNote[i]);

                }
                else if (timeSpan < remainingTime)
                {
                    if (btnNearestCalibrations.Text.Length < 25)
                    {
                        btnNearestCalibrations.Text = "Yaklaşan Kalibrasyon;      \n";
                    }
                    btnNearestCalibrations.Text += ClassGv.ActiveCalibrationList.DeviceCode[i] + ", \n";
                    btnNearestCalibrations.BackColor = Color.PaleVioletRed;

                    ClassGv.NearestCalibration.Date.Add( ClassGv.ActiveCalibrationList.Date[i]);
                    ClassGv.NearestCalibration.Time.Add( ClassGv.ActiveCalibrationList.Time[i]);
                    ClassGv.NearestCalibration.DeviceCode.Add(ClassGv.ActiveCalibrationList.DeviceCode[i]);
                    ClassGv.NearestCalibration.DeviceName.Add(ClassGv.ActiveCalibrationList.DeviceName[i]);
                    ClassGv.NearestCalibration.PurposeOfUsage.Add(ClassGv.ActiveCalibrationList.PurposeOfUsage[i]);
                    ClassGv.NearestCalibration.StructureCode.Add(ClassGv.ActiveCalibrationList.StructureCode[i]);
                    ClassGv.NearestCalibration.DeviceTag.Add(ClassGv.ActiveCalibrationList.DeviceTag[i]);
                    ClassGv.NearestCalibration.CalibrationDate.Add(ClassGv.ActiveCalibrationList.CalibrationDate[i]);
                    ClassGv.NearestCalibration.CalibrationPeriod.Add(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                    ClassGv.NearestCalibration.NextCalibrationDate.Add(ClassGv.ActiveCalibrationList.NextCalibrationDate[i]);
                    ClassGv.NearestCalibration.CalibrationNote.Add(ClassGv.ActiveCalibrationList.CalibrationNote[i]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnNearestCalibrations.Dock = DockStyle.Fill;
            btnNearestCalibrations.Enabled = false;
            btnNearestCalibrations.Text = "Yaklaşan Kalibrasyon Yok";
            btnNearestCalibrations.TextAlign = ContentAlignment.TopLeft;
            btnNearestCalibrations.Font = new Font("Microsoft Sans Serif", 11);
            tlpButton.Controls.Add(btnNearestCalibrations, 0, 4);

            btnPassedCalibrations.Dock = DockStyle.Fill;
            btnPassedCalibrations.Enabled = false;
            btnPassedCalibrations.Text = "Geçmiş Kalibrasyon Yok";
            btnPassedCalibrations.TextAlign = ContentAlignment.TopLeft;
            btnPassedCalibrations.Font = new Font("Microsoft Sans Serif", 11);
            tlpButton.Controls.Add(btnPassedCalibrations, 0, 5);

            GetDeviceList();
            GetCalibrationHistoryList();
            GetActiveCalibrationList();
            CalculateNearestAndPassedCalibration();
        }

        private void buttonPageChange_Click(object sender, EventArgs e)//page change event, if page already open don't open again
        {
            bool formOpen = false;
            int formNumber = 0;
            Button btn = sender as Button;
            var form = Application.OpenForms;

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (btn.Name == Application.OpenForms[i].Text)
                {
                    Application.OpenForms[i].Close();
                    formNumber = i;
                }
            }
         
            if(btn.Name== "FormAddDevice")
            {
                if (formOpen)
                {
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(Application.OpenForms[formNumber]);
                }
                else
                {
                    panelMain.Controls.Clear();
                    FormAddDevice form1 = new FormAddDevice
                    {
                        TopLevel = false,
                        AutoScroll = true,
                        Dock = DockStyle.Fill,
                    };
                    form1.Show();
                    panelMain.Controls.Add(form1);
                }
            }
            else if (btn.Name == "FormDevicesList")
            {
                if (formOpen)
                {
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(Application.OpenForms[formNumber]);
                }
                else
                {
                    panelMain.Controls.Clear();
                    FormDevicesList form1 = new FormDevicesList
                    {
                        TopLevel = false,
                        AutoScroll = true,
                        Dock = DockStyle.Fill,
                    };
                    form1.Show();
                    panelMain.Controls.Add(form1);
                }
            }

            else if (btn.Name == "FormCalibration")
            {
                if (formOpen)
                {
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(Application.OpenForms[formNumber]);
                }
                else
                {
                    panelMain.Controls.Clear();
                    FormCalibration form1 = new FormCalibration
                    {
                        TopLevel = false,
                        AutoScroll = true,
                        Dock = DockStyle.Fill,
                    };
                    form1.Show();
                    panelMain.Controls.Add(form1);
                }
            }

            foreach (Button item in tlpButton.Controls)
            {
                if (!item.Text.Contains("şan Kali") && !item.Text.Contains("miş Kali"))
                {
                    if (item.Name == btn.Name)
                    {
                        item.BackColor = Color.DimGray;
                        item.ForeColor = Color.White;
                        item.Font = new Font("Microsoft Sans Serif", 13);
                    }
                    else
                    {
                        item.BackColor = Color.White;
                        item.ForeColor = Color.Black;
                        item.Font = new Font("Microsoft Sans Serif", 11);
                    }
                }
            }
        }

        private void sendMail(string body)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("receiverAddress@gmail.com");
                mailMessage.From = new MailAddress("senderAddress@gmail.com", "Lütfi Yıldırım");
                mailMessage.Subject = "Kalibrasyon hatırlatması";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = body;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("senderAddress@gmail.com", "ufpm valy tidy vhbn");
                //Open two step verification and get password for application from https://myaccount.google.com/apppasswords
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                mailMessage.Dispose();
                MessageBox.Show("Successed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            string HtmlStart = "<html>";
            string HtmlEnd = "</html>";
            string Body =
                "<body>" +
                "<h2>Dikkat! &#128640;</h2>" +
                "<p>Türkiye yerleşkesinde bulunan bakımı yaklaşan veya geçen cihazlar aşağıda listelenmiştir.</p>" +
                "</body>";
            string Message = "";
            string TableStart = "<table style=\"width:50%;\">";
            string TableEnd = "</table>";
            string ThStart = "<th style =\"font-size:17px;border-style:solid;border-width:thin; padding: 1px;\">";//table header
            string ThEnd = "</th>";
            string TrStart = "<tr style =\"text-align: center;\">";//table row
            string TrEnd = "</tr>";
            string TdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 1px;\">";//table cell
            string TdEnd = "</td>";
            string NewLine = "<br>";

            Message = HtmlStart + Body;

            #region ComposeNearestCalibrationData
            if (ClassGv.NearestCalibration.Date.Count > 0)
            {
                Message += TableStart +
                TrStart + "<th colspan=5; style =\"font-size:20px; background-color:#FF0000; color:#ffffff;border-color:#5c87b2; border-style:solid; border-width:thin; padding: 1px;\">Yaklaşan Kalibrasyon" + ThEnd + TrEnd;

                Message += TrStart +
                    ThStart + "Cihaz Kodu" + ThEnd +
                    ThStart + "Cihaz Adı" + ThEnd +
                    ThStart + "Bina Kodu" + ThEnd +
                    ThStart + "Kalibrasyon Tarihi" + ThEnd +
                    ThStart + "Kalibrasyon Notu" + ThEnd +
                    TrEnd;

                for (int i = 0; i < ClassGv.NearestCalibration.Date.Count; i++)
                {
                    Message += TrStart +
                        TdStart + ClassGv.NearestCalibration.DeviceCode[i] + TdEnd +
                        TdStart + ClassGv.NearestCalibration.DeviceName[i] + TdEnd +
                        TdStart + ClassGv.NearestCalibration.StructureCode[i] + TdEnd +
                        TdStart + ClassGv.NearestCalibration.NextCalibrationDate[i] + TdEnd +
                        TdStart + ClassGv.NearestCalibration.CalibrationNote[i] + TdEnd +
                        TrEnd;
                }
            }
            #endregion

            Message += TableEnd + NewLine;

            #region ComposePassedCalibrationData
            if (ClassGv.PassedCalibration.Date.Count > 0)
            {
                Message += TableStart +
             TrStart + "<th colspan=5; style =\"font-size:20px; background-color:#7D0000; color:#ffffff;border-color:#5c87b2; border-style:solid; border-width:thin; padding: 1px;\">Süresi Geçmiş Kalibrasyon" + ThEnd + TrEnd;

                Message += TrStart +
                    ThStart + "Cihaz Kodu" + ThEnd +
                    ThStart + "Cihaz Adı" + ThEnd +
                    ThStart + "Bina Kodu" + ThEnd +
                    ThStart + "Kalibrasyon Tarihi" + ThEnd +
                    ThStart + "Kalibrasyon Notu" + ThEnd +
                    TrEnd;

                for (int i = 0; i < ClassGv.PassedCalibration.Date.Count; i++)
                {
                    Message += TrStart +
                        TdStart + ClassGv.PassedCalibration.DeviceCode[i] + TdEnd +
                        TdStart + ClassGv.PassedCalibration.DeviceName[i] + TdEnd +
                        TdStart + ClassGv.PassedCalibration.StructureCode[i] + TdEnd +
                        TdStart + ClassGv.PassedCalibration.NextCalibrationDate[i] + TdEnd +
                        TdStart + ClassGv.PassedCalibration.CalibrationNote[i] + TdEnd +
                        TrEnd;
                }
            }
            Message += TableEnd + HtmlEnd;

            #endregion

            if (ClassGv.NearestCalibration.Date.Count > 0 || ClassGv.PassedCalibration.Date.Count > 0)
            {
                sendMail(Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1 day 86400000 milliseconds
            buttonSendMail.PerformClick();
        }
    }
}