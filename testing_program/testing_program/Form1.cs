using Microsoft.Win32;
using System.Diagnostics;
using System.Xml.Linq;

namespace testing_program
{
    public partial class Form1 : Form
    {
        PerformanceCounter theCpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter theRamCounter = new PerformanceCounter("Memory", "Available MBytes");
        string name = "Aboba";
        string ExePath0 = "";

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loopRamCpu();
        }

        async Task loopRamCpu()
        {
            while (true)
            {
                labelcpu.Text = "CPU: " + theCpuCounter.NextValue().ToString() + "%";
                labelram.Text = "RAM: " + theRamCounter.NextValue().ToString() + "MB";
                await Task.Delay(1000);
            }
        }

        void deleteStandartCashe()
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\Windows\\Temp");
            foreach (FileInfo file in dirInfo.GetFiles()) IgnoreExceptions(() => file.Delete());
        }
        void deleteWebCashe()
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\User\\AppData\\Local\\Yandex\\YandexBrowser\\Temp");
            foreach (FileInfo file in dirInfo.GetFiles()) IgnoreExceptions(() => file.Delete());

            DirectoryInfo dirInfo0 = new DirectoryInfo("C:\\Users\\User\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\Cache_Data");
            foreach (FileInfo file in dirInfo0.GetFiles()) IgnoreExceptions(() => file.Delete());
        }

        async void deleteAllCashe(object sender, EventArgs e)
        {
            await Task.Run(() => deleteWebCashe());
            await Task.Run(() => deleteStandartCashe());
        }
        public void IgnoreExceptions(Action act)
        {
            try
            {
                act.Invoke();
            }
            catch { }
        }

        private void buttondeletewebcashe_Click(object sender, EventArgs e)
        {
            deleteWebCashe();
        }

        private void buttondeletestdcashe_Click(object sender, EventArgs e)
        {
            deleteStandartCashe();
        }
        public bool SetAutorunValue(bool autorun)
        {
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath0);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void buttontoautorun_Click(object sender, EventArgs e)
        {
            ExePath0 = textexetorun.Text;
            SetAutorunValue(true);
        }

        private void buttontonotautorun_Click(object sender, EventArgs e)
        {
            ExePath0 = textexetorun.Text;
            SetAutorunValue(false);
        }
    }
}