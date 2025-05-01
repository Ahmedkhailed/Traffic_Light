using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
        }

        private void ctrlTrafficLight1_RedLight(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            new Thread(() =>
                {
                    MessageBox.Show(e.LightState.ToString());
                }).Start();
        }

        private void ctrlTrafficLight1_GreenLight(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            new Thread(() =>
            {
                MessageBox.Show(e.LightState.ToString());
            }).Start();
        }

        private void ctrlTrafficLight1_YellowLight(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            new Thread(() =>
            {
                MessageBox.Show(e.LightState.ToString());
            }).Start();
        }
    }
}
