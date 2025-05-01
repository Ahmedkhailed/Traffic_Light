using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class ctrlTrafficLight : UserControl
    {
        public enum LightEnum { Red = 0, Yellow = 1, Green = 2 };
        private LightEnum _lightState = LightEnum.Red;

        private int _TimeRed;
        private int _TimeYellow;
        private int _TimeGreen;
        private int _CurrentCountDownValue;

        public int TimeRed
        {
            get { return _TimeRed; }
            set { _TimeRed = value; }
        }
        public int TimeYellow
        {
            get { return _TimeYellow; }
            set { _TimeYellow = value; }
        }
        public int TimeGreen
        {
            get { return _TimeGreen; }
            set { _TimeGreen = value; }
        }

        public class TrafficLightEventArgs : EventArgs
        {
            public LightEnum LightState { get; set; }
            public int Time { get; set; }
            public TrafficLightEventArgs(LightEnum lightState, int time)
            {
                LightState = lightState;
                Time = time;
            }
        }

        public event EventHandler<TrafficLightEventArgs> RedLight;
        public void RaiseRedLight() => RaiseRedLightOn(new TrafficLightEventArgs(LightEnum.Red, TimeRed));
        protected virtual void RaiseRedLightOn(TrafficLightEventArgs e) => RedLight?.Invoke(this, e);

        public event EventHandler<TrafficLightEventArgs> YellowLight;
        public void RaiseYellowLight() => RaiseYellowLightOn(new TrafficLightEventArgs(LightEnum.Yellow, TimeYellow));
        protected virtual void RaiseYellowLightOn(TrafficLightEventArgs e) => YellowLight?.Invoke(this, e);

        public event EventHandler<TrafficLightEventArgs> GreenLight;
        public void RaiseGreenLight() => RaiseGreenLightOn(new TrafficLightEventArgs(LightEnum.Green, TimeGreen));
        protected virtual void RaiseGreenLightOn(TrafficLightEventArgs e) => GreenLight?.Invoke(this, e);

        private void _ChangeLight()
        {
            switch (_lightState)
            {
                case LightEnum.Red:
                    lbTimer.ForeColor = Color.Yellow;
                    _lightState = LightEnum.Yellow;
                    pictureBox1.Image = Properties.Resources.traffic_light__1_;
                    RaiseYellowLight();
                    break;

                case LightEnum.Yellow:
                    lbTimer.ForeColor = Color.Green;
                    _lightState = LightEnum.Green;
                    pictureBox1.Image = Properties.Resources.traffic_light;
                    RaiseGreenLight();
                    break;

                case LightEnum.Green:
                    lbTimer.ForeColor = Color.Red;
                    _lightState = LightEnum.Red;
                    pictureBox1.Image = Properties.Resources.red_light;
                    RaiseRedLight();
                    break;
            }

            _CurrentCountDownValue = GetTimeCurrent();
        }

        public int GetTimeCurrent()
        {
            switch (_lightState)
            {
                case LightEnum.Red:
                    return TimeRed;

                case LightEnum.Yellow:
                    return TimeYellow;

                case LightEnum.Green:
                    return TimeGreen;

                default:
                    return 0;
            }
        }

        public void Start()
        {
            _CurrentCountDownValue = GetTimeCurrent();
            LightTimer.Start();
        }

        public void Stop() => LightTimer.Stop();


        public LightEnum Light
        {
            get { return _lightState; }
            set
            {
                switch (_lightState)
                {
                    case LightEnum.Red:
                        _lightState = value;
                        pictureBox1.Image = Properties.Resources.red_light;
                        break;

                    case LightEnum.Yellow:
                        _lightState = value;
                        pictureBox1.Image = Properties.Resources.traffic_light__1_;
                        break;

                    case LightEnum.Green:
                        _lightState = value;
                        pictureBox1.Image = Properties.Resources.traffic_light;
                        break;
                }
            }
        }
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            if (_CurrentCountDownValue > 1)
            {
                _CurrentCountDownValue--;
                lbTimer.Text = _CurrentCountDownValue.ToString();
            }
            else
                _ChangeLight();
        }

        private void ctrlTrafficLight_Load(object sender, EventArgs e) => lbTimer.Text = GetTimeCurrent().ToString();
    }
}
