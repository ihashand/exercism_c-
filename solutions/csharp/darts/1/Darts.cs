public static class Darts
{
    public static int Score(double x, double y)
    {
        double r2 = x * x + y * y;

        if (r2 <= 1)
            return 10;
        else if (r2 <= 25)
            return 5;
        else if (r2 <= 100)
            return 1;
        else 
            return 0;
        
       throw new NotImplementedException("You need to implement this function");
    }
}
