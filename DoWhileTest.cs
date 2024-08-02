using System;

class DoWhileTest
{
    public static void Main()
    {
        int row = 1; 
        int column, y; 

        Console.WriteLine("Multiplication Table \n");

        do
        {
            column = 1; 

            do
            {
                y = row * column; 
                Console.Write(" " + y); 
                column = column + 1; 
            }
            while (column <= 3); 

            Console.WriteLine("\n"); 
            row = row + 1; 
        }
        while (row <= 3);
    }
}
