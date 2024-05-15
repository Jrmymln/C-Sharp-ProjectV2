using System;

class Student
{
    public string? Name { get; set; }
    public double Grade { get; set; }
    public string? ScholarshipDiscount { get; set; }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[5];

        for (int i = 0; i < students.Length; i++)
        {
            students[i] = new Student();

            Console.Write($"Enter the name of student {i + 1}: ");
            students[i].Name = Console.ReadLine();

            double grade;
            Console.Write($"Enter the grade of student {i + 1} : ");
            while (!double.TryParse(Console.ReadLine(), out grade) || grade < 1.0 || grade > 5.0)
            {
                Console.WriteLine("Invalid grade. Please enter a valid grade between 1.0 to 5.0.");
            }
            students[i].Grade = grade;

            if (students[i].Grade >= 1.0 && students[i].Grade <= 1.5)
            {
                students[i].ScholarshipDiscount = "95%";
            }
            else if (students[i].Grade >= 1.6 && students[i].Grade <= 2.0)
            {
                students[i].ScholarshipDiscount = "90%";
            }
            else if (students[i].Grade >= 2.1 && students[i].Grade <= 3.0)
            {
                students[i].ScholarshipDiscount = "80%";
            }
            else if (students[i].Grade >= 3.1 && students[i].Grade <= 4.5)
            {
                students[i].ScholarshipDiscount = "50%";
            }
            else
            {
                students[i].ScholarshipDiscount = "Not Qualified";
            }
        }

        Console.WriteLine("\n--------------------------------------------------------------------");
        Console.WriteLine("Student Name:    | General Average | Scholarship Discount |");
        Console.WriteLine("--------------------------------------------------------------------");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {students[i].Name?.PadRight(15)} {students[i].Grade.ToString("F1").PadRight(18)} {students[i].ScholarshipDiscount}");
        }
        Console.WriteLine("--------------------------------------------------------------------");

        Console.ReadLine(); 
    }
}
