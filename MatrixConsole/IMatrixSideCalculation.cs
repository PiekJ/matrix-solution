namespace MatrixConsole
{
    public interface IMatrixSideCalculation
    {
        int CalculateValue(int previousValue, int xMax, int yMax);

        bool EndOfSide(int counter, int xMax, int yMax, int depth);
    }
}