namespace Traffic_Light
{
    partial class Form1
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
            this.ctrlTrafficLight1 = new Traffic_Light.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.Light = Traffic_Light.ctrlTrafficLight.LightEnum.Red;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(12, 12);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(216, 373);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.TimeGreen = 3;
            this.ctrlTrafficLight1.TimeRed = 3;
            this.ctrlTrafficLight1.TimeYellow = 3;
            this.ctrlTrafficLight1.RedLight += new System.EventHandler<Traffic_Light.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_RedLight);
            this.ctrlTrafficLight1.YellowLight += new System.EventHandler<Traffic_Light.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_YellowLight);
            this.ctrlTrafficLight1.GreenLight += new System.EventHandler<Traffic_Light.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_GreenLight);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 419);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
    }
}

