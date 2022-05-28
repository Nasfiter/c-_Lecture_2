
void FIllArray(int[] collection)
{
    int index = 0;
    int Length = collection.Length;
    while (index < Length )
    {
        collection[index] = new Random().Next(1, 100);


    index++;
    }



    
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while(possition < count)
    {
        Console.WriteLine(col[possition]);

        possition++;
    }

}





int[] Array = new int[8];

FIllArray(Array);
PrintArray(Array);
