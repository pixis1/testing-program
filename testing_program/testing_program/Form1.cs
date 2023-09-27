using System.Diagnostics;

namespace testing_program
{
    public partial class Form1 : Form
    {
        public PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click_buttonstart(object sender, EventArgs e)
        {
            while (true)
            {
                progressBarcpu.Value = (int)cpuCounter.NextValue();
                labelram.Text = ramCounter.NextValue() + "MB";
                Task.Delay(500);
            }

        }
    }
}