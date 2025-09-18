static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string returnValue = "";
        if(id != null)
           returnValue = "[" + returnValue + id + "] - ";
        
        if (name != null)
            returnValue = returnValue + name + " - ";
        
        if(department != null)
            returnValue =  returnValue + department.ToUpper();
        else 
            returnValue = returnValue + "OWNER";
            
        return returnValue;
    }
}
