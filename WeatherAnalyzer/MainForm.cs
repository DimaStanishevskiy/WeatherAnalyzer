using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Globalization;


namespace WeatherAnalyzer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");

        }

        private void textBox_NULL()
        {
            textBoxPresAvg.Text = "";
            textBoxPresMax.Text = "";
            textBoxPresMin.Text = "";
            textBoxPresLast.Text = "";

            textBoxTempAvg.Text = "";
            textBoxTempMax.Text = "";
            textBoxTempMin.Text = "";
            textBoxTempLast.Text = "";

            textBoxAirAvg.Text = "";
            textBoxAirMax.Text = "";
            textBoxAirMin.Text = "";
            textBoxAirLast.Text = "";

            textBoxHumAvg.Text = "";
            textBoxHumMax.Text = "";
            textBoxHumMin.Text = "";
            textBoxHumLast.Text = "";

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            string[] str = new string[4];
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            SerialPort port = new SerialPort("COM8", 9600);
            port.ReadTimeout = 3000;
                        
            try
            {
                port.Open();
            }
            catch
            {
                ErrorPortDialog ErrPort = new ErrorPortDialog();
                labelStreemStatus.ForeColor = Color.Red;
                labelStreemStatus.Text = "Не активний";
                ErrPort.ShowDialog();
                textBox_NULL();
                return;
            }

            labelStreemStatus.ForeColor = Color.Green;
            labelStreemStatus.Text = "Активний";
            try
            {
                for (int i = 0; i < 4; i++)
                    str[i] = port.ReadLine();
            }
            catch
            {
                ErrorPortDialog ErrPort = new ErrorPortDialog();
                labelStreemStatus.ForeColor = Color.Red;
                labelStreemStatus.Text = "Не активний";
                ErrPort.ShowDialog();
                textBox_NULL();
                return;
            }
            DateTime date = DateTime.Now;
            StreamWriter writer = new StreamWriter("data\\" + date.Day + "-" + date.Month + "-" + date.Year + ".txt",true);
            writer.WriteLine("Time=" + date.Hour + ":" + date.Minute + ":" + date.Second);
            for (int i = 0; i < 4; i++)
                writer.WriteLine(str[i]);
            writer.WriteLine("==================");
            writer.Close();

            float presMax = float.Parse(str[0] = str[0].Substring(9), nfi);
            float presMin = presMax;
            float presAvg = presMax;
            float presLast = presMax;

            float tempMax = float.Parse(str[1] = str[1].Substring(12), nfi);
            float tempMin = tempMax;
            float tempAvg = tempMax;
            float tempLast = tempMax;

            float airMax = float.Parse(str[2] = str[2].Substring(4), nfi);
            float airMin = airMax;
            float airAvg = airMax;
            float airLast = airMax;

            float humMax = float.Parse(str[3] = str[3].Substring(9), nfi);
            float humMin = humMax;
            float humAvg = humMax;
            float humLast = humMax;

            textBoxPresAvg.Text = Convert.ToString(Math.Round(presAvg,2));
            textBoxPresMax.Text = Convert.ToString(Math.Round(presMax, 2));
            textBoxPresMin.Text = Convert.ToString(Math.Round(presMin, 2));
            textBoxPresLast.Text = Convert.ToString(Math.Round(presLast, 2));

            textBoxTempAvg.Text = Convert.ToString(Math.Round(tempAvg, 2));
            textBoxTempMax.Text = Convert.ToString(Math.Round(tempMax, 2));
            textBoxTempMin.Text = Convert.ToString(Math.Round(tempMin, 2));
            textBoxTempLast.Text = Convert.ToString(Math.Round(tempLast, 2));

            textBoxAirAvg.Text = Convert.ToString(Math.Round(airAvg, 2));
            textBoxAirMax.Text = Convert.ToString(Math.Round(airMax, 2));
            textBoxAirMin.Text = Convert.ToString(Math.Round(airMin, 2));
            textBoxAirLast.Text = Convert.ToString(Math.Round(airLast, 2));

            textBoxHumAvg.Text = Convert.ToString(Math.Round(humAvg, 2));
            textBoxHumMax.Text = Convert.ToString(Math.Round(humMax, 2));
            textBoxHumMin.Text = Convert.ToString(Math.Round(humMin, 2));
            textBoxHumLast.Text = Convert.ToString(Math.Round(humLast, 2));

            while (!backgroundWorker1.CancellationPending)
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        str[i] = port.ReadLine();
                    }
                }
                catch
                {
                    ErrorPortDialog ErrPort = new ErrorPortDialog();
                    labelStreemStatus.ForeColor = Color.Red;
                    labelStreemStatus.Text = "Не активний";
                    textBox_NULL();
                    ErrPort.ShowDialog();

                    return;
                }
                date = DateTime.Now;
                writer = new StreamWriter("data\\" + date.Day + "-" + date.Month + "-" + date.Year + ".txt", true);
                writer.WriteLine("Time=" + date.Hour + ":" + date.Minute + ":" + date.Second);
                for(int i = 0; i < 4;i++)
                    writer.WriteLine(str[i]);
                writer.WriteLine("==================");
                writer.Close();

                presLast = float.Parse(str[0] = str[0].Substring(9), nfi);
                if (presLast > presMax) presMax = presLast;
                if (presLast < presMin) presMin = presLast;
                if (presAvg == -100) presAvg = presLast;
                else presAvg = (presAvg + presLast) / 2;

                tempLast = float.Parse(str[1] = str[1].Substring(12), nfi);
                if (tempLast > tempMax) tempMax = tempLast;
                if (tempLast < tempMin) tempMin = tempLast;
                if (tempAvg == -100) tempAvg = tempLast;
                else tempAvg = (tempAvg + tempLast) / 2;

                airLast = float.Parse(str[2] = str[2].Substring(4), nfi);
                if (airLast > airMax) airMax = airLast;
                if (airLast < airMin) airMin = airLast;
                if (airAvg == -100) airAvg = airLast;
                else airAvg = (airAvg + airLast) / 2;

                humLast = float.Parse(str[3] = str[3].Substring(9), nfi);
                if (humLast > humMax) humMax = humLast;
                if (humLast < humMin) humMin = humLast;
                if (humAvg == -100) humAvg = humLast;
                else humAvg = (humAvg + humLast) / 2;

                textBoxPresAvg.Text = Convert.ToString(Math.Round(presAvg, 2));
                textBoxPresMax.Text = Convert.ToString(Math.Round(presMax, 2));
                textBoxPresMin.Text = Convert.ToString(Math.Round(presMin, 2));
                textBoxPresLast.Text = Convert.ToString(Math.Round(presLast, 2));

                textBoxTempAvg.Text = Convert.ToString(Math.Round(tempAvg, 2));
                textBoxTempMax.Text = Convert.ToString(Math.Round(tempMax, 2));
                textBoxTempMin.Text = Convert.ToString(Math.Round(tempMin, 2));
                textBoxTempLast.Text = Convert.ToString(Math.Round(tempLast, 2));

                textBoxAirAvg.Text = Convert.ToString(Math.Round(airAvg, 2));
                textBoxAirMax.Text = Convert.ToString(Math.Round(airMax, 2));
                textBoxAirMin.Text = Convert.ToString(Math.Round(airMin, 2));
                textBoxAirLast.Text = Convert.ToString(Math.Round(airLast, 2));

                textBoxHumAvg.Text = Convert.ToString(Math.Round(humAvg, 2));
                textBoxHumMax.Text = Convert.ToString(Math.Round(humMax, 2));
                textBoxHumMin.Text = Convert.ToString(Math.Round(humMin, 2));
                textBoxHumLast.Text = Convert.ToString(Math.Round(humLast, 2));

            }
            port.Close();
            labelStreemStatus.ForeColor = Color.Red;
            labelStreemStatus.Text = "Не активний";
            textBox_NULL();
        }

        private void buttonStreamStart_Click(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

            
            }

        private void buttonStreemStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                labelStreemStatus.ForeColor = Color.Blue;
                labelStreemStatus.Text = "Відключається";
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
        }
    }
}
