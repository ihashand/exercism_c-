class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeInOven)
    {
        int expectedMinutesInOven = ExpectedMinutesInOven();
        int remainingMinutes = expectedMinutesInOven - timeInOven;
        return remainingMinutes;
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int preparationTime = layers * 2;
        return preparationTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutes)
    {
        int layersTime = layers * 2;
        int spentTime = layersTime + minutes; 
        return spentTime;
    }
}
