using System;

namespace MatrixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var matrixValue in Matrix.GetMatrixValues(5, 5))
            {
                Console.WriteLine(matrixValue);
            }
        }
    }
}
