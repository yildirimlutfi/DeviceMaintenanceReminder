using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceReminder
{
    public partial class FormAddDevice : Form
    {
        public FormAddDevice()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();
        private void dgvUpdate()
        {
            dataTable.Columns.Clear();
            dataTable.Rows.Clear();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;

            dataTable.Columns.Add("Eklenme Tarihi");
            dataTable.Columns.Add("Eklenme Saati");
            dataTable.Columns.Add("Cihaz Kodu");
            dataTable.Columns.Add("Cihaz Adı");
            dataTable.Columns.Add("Kullanım Amacı");
            dataTable.Columns.Add("Bina Kodu");
            dataTable.Columns.Add("Cihaz Künyesi");
            dataTable.Columns.Add("Kalibrasyon Gerekliliği");

            for (int i = 0; i < ClassGv.DeviceList.Date.Count; i++)
            {
                dataTable.Rows.Add(ClassGv.DeviceList.Date[i],
                    ClassGv.DeviceList.Time[i],
                    ClassGv.DeviceList.DeviceCode[i],
                    ClassGv.DeviceList.DeviceName[i],
                    ClassGv.DeviceList.PurposeOfUsage[i],
                    ClassGv.DeviceList.StructureCode[i],
                    ClassGv.DeviceList.DeviceTag[i],
                    ClassGv.DeviceList.CalibrationRequired[i]
                    );
            }
            dataGridView1.DataSource = dataTable;
        }

        private void AddDataToComboBox()
        {
            cbDeviceCode.Items.Clear();
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                cbDeviceCode.Items.Add(ClassGv.DeviceList.DeviceCode[i]);
            }

            cbDeviceName.Items.Clear();
            for (int i = 0; i < ClassGv.DeviceList.DeviceName.Count; i++)
            {
                cbDeviceName.Items.Add(ClassGv.DeviceList.DeviceName[i]);
            }
        }

        private void FormAddDevice_Load(object sender, EventArgs e)
        {
            AddDataToComboBox();
            dgvUpdate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbStructureCode.Text.Length == 0 ||
               cbDeviceCode.Text.Length == 0 ||
               tbPurposeOfUsage.Text.Length == 0)
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır");
            }
            else
            {
                for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
                {
                    if (ClassGv.DeviceList.DeviceCode[i]== cbDeviceCode.Text)
                    {
                        MessageBox.Show("Aynı cihaz kodu ile tekrar cihaz eklenemez");
                        return;
                    }
                }

                if (cbDeviceCode.Text.Contains(";") ||
                    cbDeviceName.Text.Contains(";") ||
                    tbPurposeOfUsage.Text.Contains(";") ||
                    tbStructureCode.Text.Contains(";") ||
                    tbDeviceTag.Text.Contains(";"))
                {
                    MessageBox.Show("Noktalı virgül içeren yazı yaılamaz ( ; )");
                    return;
                }                

                ClassTxt.Write(
                   DateTime.Now.ToString("dd/MM/yyyy") + ";" +
                   DateTime.Now.ToString("HH:mm:ss") + ";" +
                   cbDeviceCode.Text + ";" +
                   cbDeviceName.Text + ";" +
                   tbPurposeOfUsage.Text + ";" +
                   tbStructureCode.Text + ";" +
                   tbDeviceTag.Text + ";"+
                   cbCalibrationRequired.Checked+";"
                   ,ClassGv.FilePathOfDeviceList);

                FormMain.ClearDeviceData();
                FormMain.GetDeviceList();
                AddDataToComboBox();
                dgvUpdate();
                System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Files\\"+cbDeviceCode.Text);
                MessageBox.Show("Kayıt Tamamlandı");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (ClassGv.DeviceList.DeviceCode[i] == cbDeviceCode.Text)
                {
                    ClassGv.DeviceList.Date[i] = DateTime.Now.ToString("dd/MM/yyyy");
                    ClassGv.DeviceList.Time[i] = DateTime.Now.ToString("HH:mm:ss");
                    ClassGv.DeviceList.DeviceCode[i] = cbDeviceCode.Text;
                    ClassGv.DeviceList.DeviceName[i] = cbDeviceName.Text;
                    ClassGv.DeviceList.PurposeOfUsage[i] = tbPurposeOfUsage.Text;
                    ClassGv.DeviceList.StructureCode[i] = tbStructureCode.Text;
                    ClassGv.DeviceList.DeviceTag[i] = tbDeviceTag.Text;
                    ClassGv.DeviceList.CalibrationRequired[i] = cbCalibrationRequired.Checked.ToString();
                }

                temp = temp +
                    ClassGv.DeviceList.Date[i] + ";" +
                    ClassGv.DeviceList.Time[i] + ";" +
                    ClassGv.DeviceList.DeviceCode[i] + ";" +
                    ClassGv.DeviceList.DeviceName[i] + ";" +
                    ClassGv.DeviceList.PurposeOfUsage[i] + ";" +
                    ClassGv.DeviceList.StructureCode[i] + ";" +
                    ClassGv.DeviceList.DeviceTag[i] + ";" +
                    ClassGv.DeviceList.CalibrationRequired[i] + ";\n";
            }
            ClassTxt.Update(temp,ClassGv.FilePathOfDeviceList);
            FormMain.GetDeviceList();
            AddDataToComboBox();
            dgvUpdate();
            MessageBox.Show("Cihaz güncellendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                {
                    ClassGv.DeviceList.Date.Remove(ClassGv.DeviceList.Date[i]);
                    ClassGv.DeviceList.Time.Remove(ClassGv.DeviceList.Time[i]);
                    ClassGv.DeviceList.DeviceCode.Remove(ClassGv.DeviceList.DeviceCode[i]);
                    ClassGv.DeviceList.DeviceName.Remove(ClassGv.DeviceList.DeviceName[i]);
                    ClassGv.DeviceList.PurposeOfUsage.Remove(ClassGv.DeviceList.PurposeOfUsage[i]);
                    ClassGv.DeviceList.StructureCode.Remove(ClassGv.DeviceList.StructureCode[i]);
                    ClassGv.DeviceList.DeviceTag.Remove(ClassGv.DeviceList.DeviceTag[i]);                    
                    ClassGv.DeviceList.CalibrationRequired.Remove(ClassGv.DeviceList.CalibrationRequired[i]);                    
                }
            }

            string temp="";
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                temp = ClassGv.DeviceList.Date[i]+";"+
                    ClassGv.DeviceList.Time[i] + ";" +
                    ClassGv.DeviceList.DeviceCode[i] + ";" +
                    ClassGv.DeviceList.DeviceName[i] + ";" +
                    ClassGv.DeviceList.PurposeOfUsage[i] + ";" +
                    ClassGv.DeviceList.StructureCode[i] + ";" +
                    ClassGv.DeviceList.DeviceTag[i] + ";"+
                    ClassGv.DeviceList.CalibrationRequired[i] + ";";
            }
            ClassTxt.Update(temp, ClassGv.FilePathOfDeviceList);
            FormMain.ClearDeviceData();
            FormMain.GetDeviceList();
            AddDataToComboBox();
            dgvUpdate();
            MessageBox.Show("Cihaz silindi");
        }

        private void cbDeviceCode_SelectedIndexChanged(object sender, EventArgs e)
        {           
            ComboBox combo=(ComboBox)sender;
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (combo.Name == "cbDeviceCode" && cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                {
                    cbDeviceCode.Text = ClassGv.DeviceList.DeviceCode[i];
                    cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                    tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                    tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                    tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                    if (ClassGv.DeviceList.CalibrationRequired[i] == "True") cbCalibrationRequired.Checked = true;
                    else cbCalibrationRequired.Checked = false;
                    FileListUpdate();
                    return;
                }
                else if (combo.Name == "cbDeviceName" && cbDeviceName.Text == ClassGv.DeviceList.DeviceName[i])
                {
                    cbDeviceCode.Text = ClassGv.DeviceList.DeviceCode[i];
                    cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                    tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                    tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                    tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                    if (ClassGv.DeviceList.CalibrationRequired[i] == "True") cbCalibrationRequired.Checked = true;
                    else cbCalibrationRequired.Checked = false;
                    FileListUpdate();
                    return;
                }
                else//if written new device code clear all text box (action required)
                {
                    tbPurposeOfUsage.Text = "";
                    tbStructureCode.Text = "";
                    tbDeviceTag.Text = "";
                    cbCalibrationRequired.Checked = false;
                }
            }

        }

        private void dataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = dataGridView1.FilterString;
        }

        private void dataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.Sort = dataGridView1.SortString;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //ShowDevice(dataGridView1.SelectedCells[0].ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string DeviceCode = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Cihaz Kodu"].Value.ToString();

            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (DeviceCode == ClassGv.DeviceList.DeviceCode[i])
                {
                    cbDeviceCode.Text = ClassGv.DeviceList.DeviceCode[i];
                    cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                    tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                    tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                    tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                    if (ClassGv.DeviceList.CalibrationRequired[i] == "True") cbCalibrationRequired.Checked = true;
                    else cbCalibrationRequired.Checked = false;
                    return;
                }
                else//if written new device code clear all text box (action required)
                {
                    tbPurposeOfUsage.Text = "";
                    tbStructureCode.Text = "";
                    tbDeviceTag.Text = "";
                    cbCalibrationRequired.Checked = false;
                }
            }
        }

        private void FileListUpdate()
        {
            lbFileList.Items.Clear();
            string[] files = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\Files\\" + cbDeviceCode.Text);

            foreach (string file in files)
            {
                string[] fileName = file.Split('\\');//for adding the file name
                lbFileList.Items.Add(fileName[fileName.Length - 1]);
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (cbDeviceCode.Text != "" && cbDeviceCode.Text != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string item in openFileDialog.FileNames)
                    {
                        string[] nameSplit = item.Split('\\');
                        System.IO.File.Copy(item,
                            System.IO.Directory.GetCurrentDirectory() + "\\Files\\" + cbDeviceCode.Text + "\\" + nameSplit[nameSplit.Length - 1],
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
    }
}
