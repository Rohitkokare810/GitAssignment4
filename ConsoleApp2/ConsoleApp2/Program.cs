using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Task 1: ArrayList Initialization and Population
        ArrayList studentGrades = new ArrayList() { 85, 92, 78, 95, 88 };

        // Task 2: Display and Sum
        Console.WriteLine("Task 2: Displaying studentGrades and Calculating Sum");
        DisplayStudentGrades(studentGrades);
        DisplaySumOfGrades(studentGrades);

        // Task 3: Grade Addition
        studentGrades.Add(90);

        Console.WriteLine("\nTask 3: Adding a new grade (90)");
        DisplayStudentGrades(studentGrades);

        // Task 4: Grade Removal
        studentGrades.Remove(78);

        Console.WriteLine("\nTask 4: Removing the grade 78");
        DisplayStudentGrades(studentGrades);

        // Task 5: Search and Update
        int indexOfGrade95 = studentGrades.IndexOf(95);

        if (indexOfGrade95 != -1)
        {
            studentGrades[indexOfGrade95] = 96;
            Console.WriteLine("\nTask 5: Updating the grade at index " + indexOfGrade95 + " to 96");
            DisplayStudentGrades(studentGrades);
        }
        else
        {
            Console.WriteLine("\nTask 5: Grade 95 not found in studentGrades.");
        }
    }

    // Helper method to display the contents of the ArrayList
    static void DisplayStudentGrades(ArrayList studentGrades)
    {
        foreach (var grade in studentGrades)
        {
            Console.WriteLine(grade);
        }
    }

    // Helper method to calculate and display the sum of grades in the ArrayList
    static void DisplaySumOfGrades(ArrayList studentGrades)
    {
        int sum = 0;
        foreach (var grade in studentGrades)
        {
            sum += (int)grade;
        }
        Console.WriteLine("\nSum of all grades: " + sum);
        Console.ReadKey();
    }
    
}
