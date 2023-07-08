namespace NumbersGame;

internal class Program
{
    static void Main(string[] args)
    {
        StartSequence();
    }

    static void StartSequence()
    {

        int[] numberArray = new int[4]; //Delcare array of four zeros
        int[] populateResult = populateResult(numberArray); //Call Populate method

        for (int i = 0; i < populateResult.Length; i++) //Loop through array and console.writ elements
        {
            Console.Write(populateResult[i] + " ");
        }
    }
}

static int[] Populate(int[] array)
{
    //Loop through array and prompt and user for values
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Give me a number");
        string userInput = Console.ReadLine();
        int number = Int32.Parse(userInput);
        array[i] = number;
    }
    return array;
}

interface GetSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        {
        sum += array[i];
        }
return sum;
}


