using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPtest
{
    public class Model
    {
        private double _valueFahrenheit = 32;
        private double _valueCelsius = 0;

        public double ValueFahrenheit
        {
            get => _valueFahrenheit;
            set
            {
                _valueFahrenheit = value;
                _valueCelsius = (_valueFahrenheit - 32) * 5 / 9;
            }
        }

        public double ValueCelsius
        {
            get => _valueCelsius; 
            set
            {
                _valueFahrenheit = _valueCelsius * 9 / 5 + 32;
            }
        }
    }
}
