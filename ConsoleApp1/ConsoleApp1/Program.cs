using System;

class Program
{
    static void Main()
    {
        // Task 1: Declaration and Initialization
        int[][] matrix = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6},
            new int[] {7, 8, 15}
        };

        // Task 2: Accessing and Display
        int element = matrix[0][1];

        Console.WriteLine("Task 2: Displaying Matrix");
        DisplayMatrix(matrix);

        // Task 3: Modification
        matrix[1][2] = 15;

        Console.WriteLine("\nTask 3: Modified Matrix");
        DisplayMatrix(matrix);

        // Task 4: Advanced Concepts
        object[][] objectMatrix = new object[][]
        {
            new object[] {10, "Hello", 3.14},
            new object[] {true, 'A', DateTime.Now}
        };

        Console.WriteLine("\nTask 4: Displaying Object Matrix");
        DisplayObjectMatrix(objectMatrix);
    }

    // Helper method to display the jagged array of integers
    static void DisplayMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Helper method to display the jagged array of objects
    static void DisplayObjectMatrix(object[][] objectMatrix)
    {
        for (int i = 0; i < objectMatrix.Length; i++)
        {
            for (int j = 0; j < objectMatrix[i].Length; j++)
            {
                Console.Write($"{objectMatrix[i][j]} ({objectMatrix[i][j].GetType()}) ");
            }
            Console.WriteLine();
        }
    }
}
