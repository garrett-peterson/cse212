public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Set a for loop that lasts until a counter is equal to the length
        // Keep track of what the current number is by initializing it outside the loop
        // In each loop add the number to a results list 
        // Add the number to current number

        double currentNumb = number;
        List<double> results = new();

        for (int i = 0; i < length; i++)
        {
            results.Add(currentNumb);
            currentNumb += number;
        }

        return results.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I am thinking of creating a for loop, which has an int, i, that increases while under the length of the list
        // outside the for loop create 2 new lists
        // Use an if/else statement to add elements to the two different lists
        // If the index is 
        // once the loop is finished and the two lists are made, make a third list, with the elements in the correct order.
        // Items from list 2 first and then items from list 1

        List<int> left = new();
        List<int> right = new();

        List<int> results = new();

        for(int i = 0; i < data.Count; i++)
        {
            if(i >= data.Count - amount) 
            { 
                right.Add(data[i]); 
            } 
            else 
            { 
                left.Add(data[i]); 
            }
        }

        foreach (int num in right)
        {
            results.Add(num);
        }

        foreach (int num in left)
        {
            results.Add(num);
        }
        
        data.Clear();
        data.AddRange(results);
    }
}
