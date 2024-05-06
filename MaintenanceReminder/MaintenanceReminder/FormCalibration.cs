using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MaintenanceReminder
{
    public partial class FormCalibration : Form
    {
        public FormCalibration()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();
        private void dgvUpdate()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;

            dataTable.Columns.Clear();
            dataTable.Rows.Clear();

            dataTable.Columns.Add("Eklenme Tarihi");
            dataTable.Columns.Add("Eklenme Saati");
            dataTable.Columns.Add("Cihaz Kodu");
            dataTable.Columns.Add("Cihaz Adı");
            dataTable.Columns.Add("Kullanım Amacı");
            dataTable.Columns.Add("Bina Kodu");
            dataTable.Columns.Add("Cihaz Künyesi");
            dataTable.Columns.Add("Kalibrasyon Tarihi");
            dataTable.Columns.Add("Kalibrasyon Periyodu");
            dataTable.Columns.Add("Kalibrasyon Zamanı");
            dataTable.Columns.Add("Kalibrasyon Şirketi");
            dataTable.Columns.Add("Sertifika Numarası");
            dataTable.Columns.Add("Kalibrasyon Notu");

            for (int i = 0; i < ClassGv.ActiveCalibrationList.Date.Count; i++)
            {
                dataTable.Rows.Add(
                    ClassGv.ActiveCalibrationList.Date[i],
                    ClassGv.ActiveCalibrationList.Time[i],
                    ClassGv.ActiveCalibrationList.DeviceCode[i],
                    ClassGv.ActiveCalibrationList.DeviceName[i],
                    ClassGv.ActiveCalibrationList.PurposeOfUsage[i],
                    ClassGv.ActiveCalibrationList.StructureCode[i],
                    ClassGv.ActiveCalibrationList.DeviceTag[i],
                    ClassGv.ActiveCalibrationList.CalibrationDate[i],
                    ClassGv.ActiveCalibrationList.CalibrationPeriod[i],
                    ClassGv.ActiveCalibrationList.NextCalibrationDate[i],
                    ClassGv.ActiveCalibrationList.CalibrationCompany[i],
                    ClassGv.ActiveCalibrationList.NumberOfCertificate[i],
                    ClassGv.ActiveCalibrationList.CalibrationNote[i]
                    );
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[1].Visible=false;
            dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridBackColorUpdate();
        }

        private void DataGridBackColorUpdate()
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells.Count > 9)
                {
                    if (item.Cells[9].Value != null)
                    {
                        TimeSpan timeSpan = Convert.ToDateTime(Convert.ToDateTime(item.Cells[9].Value)) - DateTime.Now.Date;
                        TimeSpan remainingTime = new TimeSpan(ClassGv.MailAlertRemainingTime, 0, 0, 0, 0);
                        if (timeSpan < TimeSpan.Zero)
                        {
                            item.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (timeSpan < remainingTime)
                        {
                            item.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                        }
                    }
                }
            }
        }

        private void AddDataToComboBox()
        {
            cbDeviceCode.Items.Clear();
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (ClassGv.DeviceList.CalibrationRequired[i] == "True")
                {
                    cbDeviceCode.Items.Add(ClassGv.DeviceList.DeviceCode[i]);
                }
            }

            cbDeviceName.Items.Clear();
            for (int i = 0; i < ClassGv.DeviceList.DeviceName.Count; i++)
            {
                if (ClassGv.DeviceList.CalibrationRequired[i] == "True")
                {
                    cbDeviceName.Items.Add(ClassGv.DeviceList.DeviceName[i]);
                }
            }
        }

        private void FormCalibration_Load(object sender, EventArgs e)
        {
            AddDataToComboBox();
            dgvUpdate();
        }

        private void FileListUpdate()
        {
            lbFileList.Items.Clear();
            string[] files = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\Files\\" + cbDeviceCode.Text);

            foreach (string file in files)
            {
                string[] fileName = file.Split('\\');//for adding the file name
                lbFileList.Items.Add(fileName[fileName.Length-1]);
            }
        }

        private void cbDeviceCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassGv.ActiveCalibrationList.DeviceCode.Count>0)
            {
                for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceCode.Count; i++)
                {
                    if (cbDeviceCode.Text == ClassGv.ActiveCalibrationList.DeviceCode[i])
                    {
                        //cbDeviceCode.Text = ClassGv.ActiveCalibrationList.DeviceCode[i];
                        cbDeviceName.Text = ClassGv.ActiveCalibrationList.DeviceName[i];
                        tbPurposeOfUsage.Text = ClassGv.ActiveCalibrationList.PurposeOfUsage[i];
                        tbStructureCode.Text = ClassGv.ActiveCalibrationList.StructureCode[i];
                        tbDeviceTag.Text = ClassGv.ActiveCalibrationList.DeviceTag[i];
                        dtpCalibrationDate.Text = Convert.ToDateTime(ClassGv.ActiveCalibrationList.CalibrationDate[i]).ToString();
                        nupCalibrationPeriod.Value = Convert.ToInt16(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                        dtpNextCalibrationTime.Text = Convert.ToDateTime( ClassGv.ActiveCalibrationList.NextCalibrationDate[i]).ToString();
                        tbCalibrationCompany.Text = ClassGv.ActiveCalibrationList.CalibrationCompany[i];
                        tbNumberOfCertificate.Text = ClassGv.ActiveCalibrationList.NumberOfCertificate[i];
                        tbCalibrationNote.Text = ClassGv.ActiveCalibrationList.CalibrationNote[i];
                        FileListUpdate();
                        return;
                    }
                    else//if written new device code clear all text box (action required)
                    {
                        cbDeviceName.Text = "";
                        tbPurposeOfUsage.Text = "";
                        tbStructureCode.Text = "";
                        tbDeviceTag.Text = "";
                        dtpCalibrationDate.Text = DateTime.Now.ToString();
                        nupCalibrationPeriod.Value = 0;
                        dtpNextCalibrationTime.Text = DateTime.Now.ToString();
                        tbCalibrationCompany.Text = "";
                        tbNumberOfCertificate.Text = "";
                        tbCalibrationNote.Text = "";

                    }
                }
            }

            if (ClassGv.DeviceList.DeviceCode.Count>0)
            {
                for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
                {
                    if (cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                    {
                        //cbDeviceCode.Text = ClassGv.ActiveCalibrationList.DeviceCode[i];
                        cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                        tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                        tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                        tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                        return;
                    }
                    else//if written new device code clear all text box (action required)
                    {
                        cbDeviceName.Text = "";
                        tbPurposeOfUsage.Text = "";
                        tbStructureCode.Text = "";
                        tbDeviceTag.Text = "";
                        dtpCalibrationDate.Text = DateTime.Now.ToString();
                        nupCalibrationPeriod.Value = 0;
                        dtpNextCalibrationTime.Text = DateTime.Now.ToString();
                        tbCalibrationCompany.Text = "";
                        tbNumberOfCertificate.Text = "";
                        tbCalibrationNote.Text = "";
                    }
                }
            }
        }
        
        private void cbDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassGv.ActiveCalibrationList.DeviceName.Count > 0)
            {
                for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceName.Count; i++)
                {
                    if (cbDeviceName.Text == ClassGv.ActiveCalibrationList.DeviceName[i])
                    {
                        cbDeviceCode.Text = ClassGv.ActiveCalibrationList.DeviceCode[i];
                        //cbDeviceName.Text = ClassGv.ActiveCalibrationList.DeviceName[i];
                        tbPurposeOfUsage.Text = ClassGv.ActiveCalibrationList.PurposeOfUsage[i];
                        tbStructureCode.Text = ClassGv.ActiveCalibrationList.StructureCode[i];
                        tbDeviceTag.Text = ClassGv.ActiveCalibrationList.DeviceTag[i];
                        dtpCalibrationDate.Text = Convert.ToDateTime(ClassGv.ActiveCalibrationList.CalibrationDate[i]).ToString();
                        nupCalibrationPeriod.Value = Convert.ToInt16(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                        dtpNextCalibrationTime.Text = Convert.ToDateTime( ClassGv.ActiveCalibrationList.NextCalibrationDate[i]).ToString();
                        tbCalibrationCompany.Text = ClassGv.ActiveCalibrationList.CalibrationCompany[i];
                        tbNumberOfCertificate.Text = ClassGv.ActiveCalibrationList.NumberOfCertificate[i];
                        tbCalibrationNote.Text = ClassGv.ActiveCalibrationList.CalibrationNote[i];
                        return;
                    }
                    else//if written new device code clear all text box (action required)
                    {
                        cbDeviceCode.Text = "";
                        //cbDeviceName.Text = "";
                        tbPurposeOfUsage.Text = "";
                        tbStructureCode.Text = "";
                        tbDeviceTag.Text = "";
                        dtpCalibrationDate.Text = DateTime.Now.ToString();
                        nupCalibrationPeriod.Value = 0;
                        dtpNextCalibrationTime.Text = DateTime.Now.ToString();
                        tbCalibrationCompany.Text = "";
                        tbNumberOfCertificate.Text = "";
                        tbCalibrationNote.Text = "";
                    }
                }
            }

            if (ClassGv.DeviceList.DeviceCode.Count > 0)
            {
                for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
                {
                    if (cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                    {
                        cbDeviceCode.Text = ClassGv.DeviceList.DeviceCode[i];
                        //cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                        tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                        tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                        tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                        return;
                    }
                    else//if written new device code clear all text box (action required)
                    {
                        cbDeviceCode.Text = "";
                        //cbDeviceName.Text = "";
                        tbPurposeOfUsage.Text = "";
                        tbStructureCode.Text = "";
                        tbDeviceTag.Text = "";
                        dtpCalibrationDate.Text = DateTime.Now.ToString();
                        nupCalibrationPeriod.Value = 0;
                        dtpNextCalibrationTime.Text = DateTime.Now.ToString();
                        tbCalibrationNote.Text = "";

                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbDeviceCode.Text.Contains(";") ||
                  cbDeviceName.Text.Contains(";") ||
                  tbPurposeOfUsage.Text.Contains(";") ||
                  tbStructureCode.Text.Contains(";") ||
                  tbDeviceTag.Text.Contains(";") ||
                  dtpCalibrationDate.Text.Contains(";") ||
                  dtpNextCalibrationTime.Text.Contains(";")||
                  tbCalibrationCompany.Text.Contains(";") ||
                  tbNumberOfCertificate.Text.Contains(";") ||
                  tbCalibrationNote.Text.Contains(";") 
                  )
            {
                MessageBox.Show("Noktalı virgül içeren yazı yaılamaz ( ; )");
                return;
            }

            if (nupCalibrationPeriod.Value == 0 ||
              tbCalibrationNote.Text.Length == 0)
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır.\nKalibrasyon periyodu 0 olamaz.");
                return;
            }
            else
            {
                bool ThereIsCalibration = false;
                string temp = "";
                for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceCode.Count; i++)
                {
                    if (ClassGv.ActiveCalibrationList.DeviceCode[i]==cbDeviceCode.Text)
                    {
                        ThereIsCalibration = true;
                    }
                }

                if (ThereIsCalibration)
                {
                    for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceCode.Count; i++)
                    {
                        if (ClassGv.ActiveCalibrationList.DeviceCode[i]==cbDeviceCode.Text)
                        {
                            ClassGv.ActiveCalibrationList.Date[i] = DateTime.Now.ToString("dd/MM/yyyy");
                            ClassGv.ActiveCalibrationList.Time[i] = DateTime.Now.ToString("HH:mm:ss");
                            ClassGv.ActiveCalibrationList.DeviceCode[i] = cbDeviceCode.Text;
                            ClassGv.ActiveCalibrationList.DeviceName[i] = cbDeviceName.Text;
                            ClassGv.ActiveCalibrationList.PurposeOfUsage[i] = tbPurposeOfUsage.Text;
                            ClassGv.ActiveCalibrationList.StructureCode[i] = tbStructureCode.Text;
                            ClassGv.ActiveCalibrationList.DeviceTag[i] = tbDeviceTag.Text;
                            ClassGv.ActiveCalibrationList.CalibrationDate[i] = dtpCalibrationDate.Text;
                            ClassGv.ActiveCalibrationList.CalibrationPeriod[i] = nupCalibrationPeriod.Value.ToString();
                            ClassGv.ActiveCalibrationList.NextCalibrationDate[i] = dtpNextCalibrationTime.Text;
                            ClassGv.ActiveCalibrationList.CalibrationCompany[i] = tbCalibrationCompany.Text;
                            ClassGv.ActiveCalibrationList.NumberOfCertificate[i] = tbNumberOfCertificate.Text;
                            ClassGv.ActiveCalibrationList.CalibrationNote[i] = tbCalibrationNote.Text;
                        }

                        temp = temp+
                            ClassGv.ActiveCalibrationList.Date[i] + ";" +
                            ClassGv.ActiveCalibrationList.Time[i] + ";" +
                            ClassGv.ActiveCalibrationList.DeviceCode[i] + ";" +
                            ClassGv.ActiveCalibrationList.DeviceName[i] + ";" +
                            ClassGv.ActiveCalibrationList.PurposeOfUsage[i] + ";" +
                            ClassGv.ActiveCalibrationList.StructureCode[i] + ";" +
                            ClassGv.ActiveCalibrationList.DeviceTag[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationDate[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationPeriod[i] + ";" +
                            ClassGv.ActiveCalibrationList.NextCalibrationDate[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationCompany[i] + ";" +
                            ClassGv.ActiveCalibrationList.NumberOfCertificate[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationNote[i] + ";\n";
                    }
                    ClassTxt.Update(temp, ClassGv.FilePathOfActiveCalibrationList);
                }
                else
                {
                    ClassTxt.Write(
                       DateTime.Now.ToString("dd/MM/yyyy") + ";" +
                       DateTime.Now.ToString("HH:mm:ss") + ";" +
                       cbDeviceCode.Text + ";" +
                       cbDeviceName.Text + ";" +
                       tbPurposeOfUsage.Text + ";" +
                       tbStructureCode.Text + ";" +
                       tbDeviceTag.Text + ";" +
                       dtpCalibrationDate.Text + ";" +
                       nupCalibrationPeriod.Value.ToString() + ";" +
                       dtpNextCalibrationTime.Text + ";" +
                       tbCalibrationCompany.Text + ";" +
                       tbNumberOfCertificate.Text + ";" +
                       tbCalibrationNote.Text + ";"
                       , ClassGv.FilePathOfActiveCalibrationList);
                }

                ClassTxt.Write(
                   DateTime.Now.ToString("dd/MM/yyyy") + ";" +
                   DateTime.Now.ToString("HH:mm:ss") + ";" +
                   cbDeviceCode.Text + ";" +
                   cbDeviceName.Text + ";" +
                   tbPurposeOfUsage.Text + ";" +
                   tbStructureCode.Text + ";" +
                   tbDeviceTag.Text + ";" +
                   dtpCalibrationDate.Text + ";" +
                   nupCalibrationPeriod.Value.ToString() + ";" +
                   dtpNextCalibrationTime.Text + ";" +
                   tbCalibrationCompany.Text + ";" +
                   tbNumberOfCertificate.Text + ";" +
                   tbCalibrationNote.Text + ";"
                   , ClassGv.FilePathOfCalibrationHistoryList);

                FormMain.GetCalibrationHistoryList();
                FormMain.CalculateNearestAndPassedCalibration();

                FormMain.ClearNearestAndPassedCalibration();
                FormMain.CalculateNearestAndPassedCalibration();

                FormMain.GetActiveCalibrationList();
                dgvUpdate();

                MessageBox.Show("Güncelleme Tamamlandı");
            }
        }

        private void mtbCalibrationPeriod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime calibrationTime = Convert.ToDateTime(dtpCalibrationDate.Text);
                DateTime nextCalibrationTime = Convert.ToDateTime(dtpCalibrationDate.Text).AddMonths(Convert.ToInt32(nupCalibrationPeriod.Value.ToString()));
                dtpNextCalibrationTime.Text = nextCalibrationTime.ToShortDateString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = dataGridView1.FilterString;
            DataGridBackColorUpdate();
        }

        private void dataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.Sort = dataGridView1.SortString;
            DataGridBackColorUpdate();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (cbDeviceCode.Text!="" && cbDeviceCode.Text!=null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    foreach (string item in openFileDialog.FileNames)
                    {
                        string[] nameSplit = item.Split('\\');
                        System.IO.File.Copy(item,
                            System.IO.Directory.GetCurrentDirectory() + "\\Files\\" + cbDeviceCode.Text+"\\"+ nameSplit[nameSplit.Length-1],
                            true);
                    }
                    FileListUpdate();
                    MessageBox.Show("Başarılı");
                }
            }
            else
            {
                MessageBox.Show("Cihaz seçiniz");
            }

            #region GetFiles doesn't use but it's working
            //if (cbDeviceCode.Text != "" || cbDeviceCode.Text != null)
            //{
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Files\\" + cbDeviceCode.Text;
            //    openFileDialog.Multiselect = true;
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //        //saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory().Split('\\')[0];
            //        //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //        if (folderBrowser.ShowDialog() == DialogResult.OK)
            //        {
            //            foreach (string item in openFileDialog.FileNames)
            //            {
            //                string[] nameSplit = item.Split('\\');
            //                System.IO.File.Copy(item,
            //                    folderBrowser.SelectedPath + "\\" + nameSplit[nameSplit.Length - 1],
            //                    true);
            //            }
            //        }
            //    }
            //}
            #endregion
        }

        private void lbFileList_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\Files\\" + cbDeviceCode.Text + "\\" + lbFileList.SelectedItem.ToString());
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                DataGridBackColorUpdate();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string DeviceCode = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Cihaz Kodu"].Value.ToString();

            for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceCode.Count; i++)
            {
                if (DeviceCode == ClassGv.ActiveCalibrationList.DeviceCode[i])
                {
                    cbDeviceCode.Text = ClassGv.ActiveCalibrationList.DeviceCode[i];
                    cbDeviceName.Text = ClassGv.ActiveCalibrationList.DeviceName[i];
                    tbPurposeOfUsage.Text = ClassGv.ActiveCalibrationList.PurposeOfUsage[i];
                    tbStructureCode.Text = ClassGv.ActiveCalibrationList.StructureCode[i];
                    tbDeviceTag.Text = ClassGv.ActiveCalibrationList.DeviceTag[i];
                    dtpCalibrationDate.Text = Convert.ToDateTime(ClassGv.ActiveCalibrationList.CalibrationDate[i]).ToString();
                    nupCalibrationPeriod.Value = Convert.ToInt16(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                    dtpNextCalibrationTime.Text = Convert.ToDateTime(ClassGv.ActiveCalibrationList.NextCalibrationDate[i]).ToString();
                    tbCalibrationCompany.Text = ClassGv.ActiveCalibrationList.CalibrationCompany[i];
                    tbNumberOfCertificate.Text = ClassGv.ActiveCalibrationList.NumberOfCertificate[i];
                    tbCalibrationNote.Text = ClassGv.ActiveCalibrationList.CalibrationNote[i];
                    return;
                }
                else//if written new device code clear all text box (action required)
                {
                    tbPurposeOfUsage.Text = "";
                    tbStructureCode.Text = "";
                    tbDeviceTag.Text = "";
                }
            }
        }
    }
}
