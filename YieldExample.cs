
    // Yields numbers from 0 to 9 and returns {0,1,2,3,4,5,6,7,8,9}
    public IEnumerable<int> YieldBreak()
    {
        for (int i = 0; ; i++)
        {
            if (i < 10)
            {
                // Yields a number
                yield return i;
            }
            else
            {
                // Iteration has ended, everything from this line will be ignored
                yield break;
            }
        }
        yield return 10; // This return will never get executed
    }
 
    // Yields numbers from 0 to 10 returns "0,1,2,3,4,5,6,7,8,9,10"
    public IEnumerable<int> JustBreak()
    {
        for (int i = 0; ; i++)
        {
            if (i < 10)
            {
                // Yields a number
                yield return i;
            }
            else
            {
                // Terminates just the loop
                break;
            }
        }
        // Here the Execution continues
        yield return 10;
    }