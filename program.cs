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
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("|                     Student Scholarship System                    |");
        Console.WriteLine("--------------------------------------------------------------------\n");

        
        Student[] students = new Student[5];

        for (int i = 0; i < students.Length; i++)
        {
            students[i] = new Student();

            Console.WriteLine($"Enter the details for student {i + 1}:\n");

            
            Console.Write("Name: ".PadRight(15));
            students[i].Name = Console.ReadLine();

            
            double grade;
            do
            {
                Console.Write("G.A: ".PadRight(15));
                while (!double.TryParse(Console.ReadLine(), out grade) || grade < 1.0 || grade > 5.0)
                {
                    Console.WriteLine("Invalid grade. Please enter a valid grade between 1.0 to 5.0.");
                    Console.Write("Grade: ".PadRight(15));
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

            } while (students[i].Grade < 1.0 || students[i].Grade > 5.0);
            
            Console.WriteLine();
        }

        
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("|                           Results                                |");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("| Student Name   | General Average | Scholarship Discount          |");
        Console.WriteLine("--------------------------------------------------------------------");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"| {students[i].Name?.PadRight(15)} | {students[i].Grade.ToString("F1").PadRight(15)} | {students[i].ScholarshipDiscount.PadRight(21)} |");
        }
        Console.WriteLine("--------------------------------------------------------------------");

        Console.ReadLine(); 
    }
}
