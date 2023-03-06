using System.Collections.Specialized;

namespace Lab2_1
{
    internal class students
{
    static void Main(string[] args)
    {
                List<Student> students = GetStudentsFromFile("list.txt");
            if (!File.Exists("list.txt")) { 
                Console.WriteLine("file not exist"); }
            List<Student> filteredStudents = students.Where(s => (s.Note1 + s.Note2) / 2.0 > 60).ToList();
         

                for (int i = 0; i < filteredStudents.Count; i++)
        {
            Console.WriteLine("{0} {1}: {2}", filteredStudents[i].FirstName, filteredStudents[i].LastName, (filteredStudents[i].Note1 + filteredStudents[i].Note2) / 2.0);
        }

        static List<Student> GetStudentsFromFile(string filePath)
        {
            List<Student> students = new List<Student>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Student student = new Student
                    {
                        FirstName = parts[0].Trim(),
                        LastName = parts[1].Trim(),
                        Note1 = int.Parse(parts[2]),
                        Note2 = int.Parse(parts[3])
                    };
                    students.Add(student);
                }
            }
   

            return students;
        }
    }
}
}
