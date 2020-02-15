namespace MatrixConsole
{
    public class TopBottomMatrixSideCalculator : IMatrixSideCalculation
    {
        public int CalculateValue(int previousValue, int xMax, int yMax)
        {
            return previousValue + xMax;
        }

        public bool EndOfSide(int counter, int xMax, int yMax, int depth)
        {
            return counter == yMax - depth * 2 - 1;
        }
    }
}