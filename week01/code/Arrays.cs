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
        //Solution- Plan
        //1.We first create  an array of size 'length' to store the multiples, this creates an array of the required size
        double[] result = new double[length];
        //2. and then we loop from 0 to length-1 to calculate each multiple
        for (int i = 0; i < length; i++)
        {
            // 3. multiply the 'number' by (i + 1) to get the i-th multiple 
            result[i] = number * (i + 1);
        }
        ////4. return the filled array containing all the multiples
        return result;
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
        // Solution 2:Plan
        //1.The list length may be equal to the rotation amount,
        // so we need to normalize the amount to avoid unnecessary full rotations.
        amount = amount % data.Count;

        // 2. If the rotation amount is 0 after normalization,
        // there is nothing to rotate, so we can exit early.
        if (amount == 0)
            return;

        //3. Identify the starting index of the elements that will move
        // to the front of the list. These are the last 'amount' elements.
        int splitIndex = data.Count - amount;

        //4.copy the last 'amount' elements into a temporay list
        List<int> tail = data.GetRange(splitIndex, amount);

        //5. Remove copied elements from their original positions
         data.RemoveRange(splitIndex, amount);

        // 6. Insert the saved elements at the beginning of the list
            data.InsertRange(0, tail);
}
}
