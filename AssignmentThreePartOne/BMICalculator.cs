using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreePartOne
{
    internal class BMICalculator
    {
        private double height;
        private double weight;

        private UnitType unit;

        public BMICalculator()
        {
            unit = UnitType.Metric;
        }

        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            if(height >= 0.0)
            this.height = height;
        }

        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double weight)
        {
            if (weight >= 0)
                this.weight = weight;
        }
        public UnitType GetUnit()
        {
            return unit;
        }
        public void SetUnit(UnitType unit)
        {
            this.unit = unit;
        }

        //Calculations

        //Pounds and Foots
        //Formula: weight (lb) / [height(in)]2 * 703
        // Calculate BMI by diving weight in pounds (lbs) by height in foots
        //Example: weight = 150 lbs, height = 5'5" (65")
        //Calculation: [150 / (65)2]
        //            * 703 = 24.96

        public double CalculateBMI()
        {
            //metric values
            //Height must be in metric or foot
            double bmiValue = 0.0;
            double factor = 1.0;

            if(unit == UnitType.Imperial)
            {
                factor = 703.0;
            }
            bmiValue = factor * weight / (height * height);

            return bmiValue;
        }

        //
        ///<summary>
        ///Method that sets the weight category depending on the value of BMI.
        ///Notice that it call the method Calculate BMI before setting the categories
        ///</summary>
        ///<returns>Weight category based on the bmi-value.</returns>
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;

            if (bmi < 18.5)
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight";
            else if (bmi <= 29.9)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.0)
                stringout = "Overweight (Obesity class II)";
            else // (bmi >= 40)
                stringout = "Overweight (Obesity class III)";

            return stringout;
        }
    }
}
