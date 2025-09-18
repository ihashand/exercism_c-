static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
            return 3.213f;

        if(balance < 1000)
            return 0.5f;

        if(balance >= 1000 && balance < 5000)
            return 1.621f;

        if(balance >= 5000)
            return 2.475f;
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance) * (balance / 100);
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {        
        return Interest(balance) + balance;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int x = 0;
        
        do{
            
         balance = AnnualBalanceUpdate(balance);
         x++;
         
        }while (balance <= targetBalance);

        return (int) x;
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
