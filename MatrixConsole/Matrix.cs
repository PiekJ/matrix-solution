using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace MatrixConsole
{
    public class Matrix
    {
        private static readonly IMatrixSideCalculation[] MatrixSideCalculations =
        {
            new LeftRightMatrixSideCalculator(), 
            new TopBottomMatrixSideCalculator(), 
            new RightLeftMatrixSideCalculator(), 
            new BottomTopMatrixSideCalculator()
        };

        public static IEnumerable<int> GetMatrixValues(int xMax, int yMax)
        {
            var currentValue = 0;
            var depth = 0;
            var counter = 0;
            var calculatorCounter = 0;

            for (var i = 0; i < xMax * yMax; i++)
            {
                counter++;

                var calculatorIndex = calculatorCounter % MatrixSideCalculations.Length;

                var calculator = MatrixSideCalculations[calculatorIndex];

                currentValue = calculator.CalculateValue(currentValue, xMax, yMax);

                yield return currentValue;

                if (calculator.EndOfSide(counter, xMax, yMax, depth))
                {
                    counter = 0;

                    if (++calculatorCounter % MatrixSideCalculations.Length == 0)
                    {
                        depth++;
                    }
                }
            }
        }
    }
}