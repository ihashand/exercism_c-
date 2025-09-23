class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] arr1 = {0, 2, 5, 3, 7, 8, 4};
        return arr1;
    }

    public int Today() => birdsPerDay[birdsPerDay.Length-1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length-1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int number in birdsPerDay)
        {
            if(number == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int summary = 0;
        
        for (int i = 0; i < numberOfDays; i++)
        {
           summary = summary + birdsPerDay[i];
        }
        return summary;
    }

    public int BusyDays()
    {
        int summary = 0;

        foreach (int number in birdsPerDay)
        {
            if(number >= 5)
                summary = summary + 1;
        }
        
        return summary;
            
    }
}
