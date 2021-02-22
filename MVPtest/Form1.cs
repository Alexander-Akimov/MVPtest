using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPtest
{
    public partial class FormView : Form, IView
    {
        public FormView()
        {
            InitializeComponent();
        }

        public double InputDegree => Convert.ToDouble(inputBox.Text);

        public event EventHandler<EventArgs> SetFarenheit;
        public event EventHandler<EventArgs> SetCelsius;

        public void CelsiusSet(double celsiusValue)
        {
            celsiusBox.Text = $"{celsiusValue:N2}";
        }

        public void FarenheitSet(double farenheitValue)
        {
            farenheitBox.Text = $"{farenheitValue:N2}";
        }

        private void farenheitButton_Click(object sender, EventArgs e)
        {
            if (SetFarenheit != null)
                SetFarenheit(this, EventArgs.Empty);
        }

        private void celsiusButton_Click(object sender, EventArgs e)
        {
            if (SetCelsius != null)
                SetCelsius(this, EventArgs.Empty);
        }
    }
}
