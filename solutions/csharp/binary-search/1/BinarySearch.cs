public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int L = 0;
        int R = input.Length - 1;

        
        while(L <= R)
        {
            int midIdx = L + (R-L) / 2;
            int midVal = input[midIdx];
            Console.WriteLine($"idx={midIdx}, val={midVal}r");
            
            if(midVal == value)
                return midIdx;
            
            if(midVal > value)
                R = midIdx - 1;
            
            if(midVal < value)
                L = midIdx + 1;
        }
        return -1;
    }
}
