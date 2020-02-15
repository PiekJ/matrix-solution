namespace MatrixConsole
{
    public class LeftRightMatrixSideCalculator : IMatrixSideCalculation
    {
        public int CalculateValue(int previousValue, int xMax, int yMax)
        {
            return previousValue + 1;
        }

        public bool EndOfSide(int counter, int xMax, int yMax, int depth)
        {
            return counter == xMax - depth * 2;
        }
    }
}