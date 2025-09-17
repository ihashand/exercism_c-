public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
       
        string fakeNumber = phoneNumber.Substring(4,3);
        string newYorkNumber = phoneNumber.Substring(0,3);
        string lastFourDigits = phoneNumber.Substring(8,4);

        bool isNewYork = false;
        bool isFake = false;
        
        if(newYorkNumber == "212")
            isNewYork = true;
 
        if(fakeNumber == "555")
            isFake = true;
        
        return (isNewYork, isFake, lastFourDigits);
        
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
