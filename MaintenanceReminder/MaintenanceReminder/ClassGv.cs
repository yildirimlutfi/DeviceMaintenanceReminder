using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceReminder
{
    public class DeviceProperties
    {
        public List<string> Date = new List<string>();
        public List<string> Time = new List<string>();
        public List<string> DeviceCode = new List<string>();
        public List<string> DeviceName = new List<string>();
        public List<string> PurposeOfUsage = new List<string>();
        public List<string> StructureCode = new List<string>();
        public List<string> DeviceTag = new List<string>();
        public List<string> CalibrationRequired = new List<string>();
    }
    public class CalibrationProperties
    {
        public List<string> Date = new List<string>();
        public List<string> Time = new List<string>();
        public List<string> DeviceCode = new List<string>();
        public List<string> DeviceName = new List<string>();
        public List<string> PurposeOfUsage = new List<string>();
        public List<string> StructureCode = new List<string>();
        public List<string> DeviceTag = new List<string>();
        public List<string> CalibrationDate = new List<string>();
        public List<string> CalibrationPeriod = new List<string>();
        public List<string> NextCalibrationDate = new List<string>();
        public List<string> CalibrationCompany = new List<string>();
        public List<string> NumberOfCertificate = new List<string>();
        public List<string> CalibrationNote = new List<string>();
    }

    public class ClassGv
    {
        public static string FilePathOfActiveCalibrationList = System.IO.Directory.GetCurrentDirectory() + "\\Tables\\ActiveCalibrationList.txt";
        public static string FilePathOfDeviceList= System.IO.Directory.GetCurrentDirectory() + "\\Tables\\DeviceList.txt";
        public static string FilePathOfCalibrationHistoryList = System.IO.Directory.GetCurrentDirectory() + "\\Tables\\CalibrationHistoryList.txt";
        public static string DataOfTxtFile { get; set; }

        public static Int16 MailAlertRemainingTime = 10;

        public static DeviceProperties DeviceList=new DeviceProperties();
        public static CalibrationProperties CalibrationHistoryList=new CalibrationProperties();
        public static CalibrationProperties ActiveCalibrationList = new CalibrationProperties();
        public static CalibrationProperties NearestCalibration= new CalibrationProperties();
        public static CalibrationProperties PassedCalibration= new CalibrationProperties();


    }
}
