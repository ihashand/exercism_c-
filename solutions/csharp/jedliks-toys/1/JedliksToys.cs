class RemoteControlCar
{
    int distance = 0;
    int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if(battery == 0)
            return "Battery empty";
        else
            return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if(battery == 0)
            BatteryDisplay();
        else
        {
            battery = battery - 1;
            distance = distance + 20;
        }
    }
}
