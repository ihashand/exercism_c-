static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
            return 0;
        if(speed >= 1 && speed<= 4)
            return 1;
        if(speed >= 5 &&  speed <= 8)
            return 0.9;
        if(speed == 9)
            return 0.8;
        if(speed == 10)
            return 0.77;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        
        if(speed == 0)
            return 0;
        else
            return SuccessRate(speed) * speed * 221.0;
            
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
