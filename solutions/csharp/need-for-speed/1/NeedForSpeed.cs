class RemoteControlCar
{
    private int batteryDrain;
    private int speed;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.batteryDrain = batteryDrain;    
        this.speed = speed;   
    }
    
    int distance = 0;
    int battery = 100;
    
    public bool BatteryDrained()
    {
        if(battery == 0 || battery < batteryDrain)
            return true;
        return false;
    }

    public int DistanceDriven() => distance;

    public void Drive()
    {
        if(battery >= batteryDrain)
        {
            battery = battery - batteryDrain;
            distance = distance + speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
        
    public bool TryFinishTrack(RemoteControlCar car)
    {
        
        do{
            car.Drive();
        }while(!car.BatteryDrained());
        
        if(car.DistanceDriven() >= distance)
            return true;
        
        return false;
    }
}
