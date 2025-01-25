class MarksGrades2DArray
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int number = int.Parse(Console.ReadLine());
        int[,] marks = new int[number, 3];
        double[] percentages = new double[number];
        char[] grades = new char[number];

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter marks of student {i + 1} in subject {j + 1}: ");
                int mark = int.Parse(Console.ReadLine());
                if (mark < 0)
                {
                    j--;
                    continue;
                }
                marks[i, j] = mark;
            }
        }

        for (int i = 0; i < number; i++)
        {
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            if (percentages[i] >= 90) grades[i] = 'A';
            else if (percentages[i] >= 75) grades[i] = 'B';
            else if (percentages[i] >= 50) grades[i] = 'C';
            else grades[i] = 'D';
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Student {i + 1}: Percentage={percentages[i]:F2}, Grade={grades[i]}");
        }
    }
}

