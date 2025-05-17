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

        var multiples = new double[length]; // instantiated results array with size of input ('length')

        for(int i=1; i<=length; i++){ // loop through counter for iteratations equal - input ('length')
            multiples[i-1] = number*i; // replaced data in results array with multiples of input ('number')
        }                              // using each new instace of counter 'i' as multiplier for 'number'

        return multiples; // return results array now populated with 'length' multiples of 'number'
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

        for(int i=1; i<=amount; i++){               // loop to iterate the rotating swap for 'amount' times.
            int arrLen = data.Count;                // intantiated variable to be able to use nth term without data object calling a function of itself (i.e. data[data.Count])
            int lastCell = data[arrLen-1];          // placeholder for final value of 'data' in current iteration of the rotate algorithm
            for(int j=(data.Count)-1; j>0; j--){    // loop to iterate through each value of 'data'
                data[j] = data[j-1];                // replace each value of 'data' with the term to it's left - starting at the end effectively rotating each term 1 space to the right
            }
            data[0] = lastCell;                      
                                                    // (i.e. taking value from far right and rotating it through to far left)
        }
    }
}