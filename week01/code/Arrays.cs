using System.Globalization;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    public static double[] MultiplesOf(double number, int length) /// Function to produce an array of multiples of 3 and length 5
   
    {
        // TODO Problem 1 Start
        // Plan:
        // 1. Create a new array of doubles whose size is 'length'.
        // 2. The first multiple is 1 * number, the second is 2 * number, and so on.
        // 3. Loop from index 0 to length - 1. At each index i, store number * (i + 1).
        // 4. Return the filled array.

        double[] multiples = new double[length];  /// Create an array of doubles with the specified length

        for (int i = 0; i < length; i++)   /// Loop through each index of the array
        {
            multiples[i] = number * (i + 1);   /// Calculate the multiple and store it in the array
        }

        return multiples; /// Return the filled array of multiples
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
        // Plan:
        // 1. Rotating right by 'amount' means the last 'amount' items move to the front.
        //    Example: amount 3 on {1,2,3,4,5,6,7,8,9} takes {7,8,9} and puts it before {1,2,3,4,5,6}.
        // 2. Find where that split happens: start of the tail is at index data.Count - amount.
        // 3. Copy the tail (last 'amount' items) and the head (everything before the tail).
        // 4. Clear the original list, then add the tail followed by the head.
        //    That mutates 'data' in place, which is required by the problem.

        int splitIndex = data.Count - amount;  // Calculate the index where the list will be split into first and last parts
        List<int> tail = data.GetRange(splitIndex, amount);    // Get the last 'amount' items from the list as the last part
        List<int> head = data.GetRange(0, splitIndex);  // Get the items before the tail as the first part

        data.Clear();  // Clear the original list to prepare for adding the rotated elements
        data.AddRange(tail);  // Add the tail elements to the front of the list
        data.AddRange(head);  // Add the head elements after the tail to complete the rotation
    }
}






