using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _317Test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void numberboxTempValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
            if (comboUnits.SelectedIndex == 0)
            {
                lblConversion1Value.Text = $"{FarToCel(Convert.ToDouble(numberboxTempValue.Value))} C°";
                lblConversion2Value.Text = $"{FarToKel(Convert.ToDouble(numberboxTempValue.Value))} K°";
            }
            else if (comboUnits.SelectedIndex == 1)
            {
                lblConversion1Value.Text = $"{CelToKel(Convert.ToDouble(numberboxTempValue.Value))} K°";
                lblConversion2Value.Text = $"{CelToFar(Convert.ToDouble(numberboxTempValue.Value))} F°";
            }
            else if (comboUnits.SelectedIndex == 2)
            {

                lblConversion1Value.Text = $"{KelToCel(Convert.ToDouble(numberboxTempValue.Value))} C°";
                lblConversion2Value.Text = $"{KelToFar(Convert.ToDouble(numberboxTempValue.Value))} F°";
            }
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateImage();
            if (comboUnits.SelectedIndex == 0)
            {
                lblConversion1Value.Text = $"{FarToCel(Convert.ToDouble(numberboxTempValue.Value))} C°";
                lblConversion2Value.Text = $"{FarToKel(Convert.ToDouble(numberboxTempValue.Value))} K°";
                
            }
            else if (comboUnits.SelectedIndex == 1)
            {
                lblConversion1Value.Text = $"{CelToKel(Convert.ToDouble(numberboxTempValue.Value))} K°";
                lblConversion2Value.Text = $"{CelToFar(Convert.ToDouble(numberboxTempValue.Value))} F°";
            }
            else if (comboUnits.SelectedIndex == 2)
            {
                lblConversion1Value.Text = $"{KelToCel(Convert.ToDouble(numberboxTempValue.Value))} C°";
                lblConversion2Value.Text = $"{KelToFar(Convert.ToDouble(numberboxTempValue.Value))} F°";
            }
        }

        private double FarToCel(double f)
        {

            return (f - 32) * 5 / 9;
        }

       private double FarToKel(double f)
        {

            return FarToCel(f) + 273.15;
        }

        private double CelToFar(double c)
        {

            return (c * 9 / 5) + 32;
        }

        private double CelToKel(double c)
        {

            return c + 273.15;
        }

        private double KelToCel(double k)
        {
            return k - 273.15;
        }

        private double KelToFar(double k)
        {
            return (KelToCel(k) * 9 / 5) + 32;
        }

        private void UpdateImage()
        {
            double t;
            if (comboUnits.SelectedIndex == 0)
            {
                t = Convert.ToDouble(numberboxTempValue.Value);
                if (t >= 95)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_hot;
                }
                else if (t >= 75)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_warm;
                }
                else if (t >= 55)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_mild;
                }
                else if (t >= 33)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_cold;
                }
                else
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_freezing;
                }
            }
            else if (comboUnits.SelectedIndex == 1)
            {
                t = CelToFar(Convert.ToDouble(numberboxTempValue.Value));
                if (t >= 95)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_hot;
                }
                else if (t >= 75)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_warm;
                }
                else if (t >= 55)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_mild;
                }
                else if (t >= 33)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_cold;
                }
                else
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_freezing;
                }
            }
            else if (comboUnits.SelectedIndex == 2)
            {
                t = KelToFar(Convert.ToDouble(numberboxTempValue.Value));
                if (t >= 95)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_hot;
                }
                else if (t >= 75)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_warm;
                }
                else if (t >= 55)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_mild;
                }
                else if (t >= 33)
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_cold;
                }
                else
                {
                    imageTempGuage.Image = Properties.Resources.temperaturegauge_freezing;
                }
            }

            
        }

        private void labelStartTemp_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
