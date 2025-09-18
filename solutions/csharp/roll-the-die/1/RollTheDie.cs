public class Player
{
    public int RollDie()
    {
        Random rnd = new Random();
        
        return rnd.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new Random();
        
        return rnd.NextDouble()  * (100 - 0) + 0;
    }
}
