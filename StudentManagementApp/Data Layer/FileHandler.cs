using StudentManagementApp.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp.Data_Layer
{
    internal class FileHandler
    {
        private const string UserFile = "UserFile.txt";

        public void WriteToFile(string email, string password)
        {
            using (StreamWriter writer = new StreamWriter(UserFile, true))
            {
                writer.WriteLine(email + "," + password);
                writer.Close();
            }
        }

        public string ReadFromFile(string email, string password)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(UserFile).ToList();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    if (parts[0] == email)
                    {
                        if (parts[1] == password)
                        {
                            return "Successfull";
                        }
                        else
                        {
                            return "Incorrect Password";
                        }
                    }
                }
            }
            return "Incorrect Email";
        }

        private const string StudentFile = "students.txt";

        public DataTable ReadAllStudents()
        {
            DataTable studentTable = new DataTable();
            studentTable.Columns.Add("StudentNumber");
            studentTable.Columns.Add("Name");
            studentTable.Columns.Add("Surname");
            studentTable.Columns.Add("DateOfBirth");
            studentTable.Columns.Add("Age");
            studentTable.Columns.Add("Gender");
            studentTable.Columns.Add("Phone");
            studentTable.Columns.Add("Address");

            if (File.Exists(StudentFile))
            {
                var lines = File.ReadAllLines(StudentFile);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8)  
                    {
                        studentTable.Rows.Add(parts);
                    }
                }
            }

            return studentTable;
        }

        public void WriteStudentToFile(Student student)
        {
            using (StreamWriter writer = new StreamWriter(StudentFile, true))
            {
                writer.WriteLine($"{student.StudentNumber},{student.FirstName},{student.LastName},{student.DateOfBirth:yyyy-MM-dd},{student.Age},{student.Gender},{student.Phone},{student.Address}");
            }
        }

        public void UpdateStudentInFile(Student updatedStudent)
        {
            if (!File.Exists(StudentFile)) return;

            var lines = File.ReadAllLines(StudentFile).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length == 8 && int.TryParse(parts[0], out int studentNumber) && studentNumber == updatedStudent.StudentNumber)
                {
                    lines[i] = $"{updatedStudent.StudentNumber},{updatedStudent.FirstName},{updatedStudent.LastName},{updatedStudent.DateOfBirth:yyyy-MM-dd},{updatedStudent.Age},{updatedStudent.Gender},{updatedStudent.Phone},{updatedStudent.Address},{updatedStudent.Course}";
                    break;
                }
            }

            File.WriteAllLines(StudentFile, lines);
        }

        public void DeleteStudentFromFile(int studentNumber)
        {
            if (!File.Exists(StudentFile)) return;

            var lines = File.ReadAllLines(StudentFile).ToList();
            lines = lines.Where(line =>
            {
                var parts = line.Split(',');
                return !(parts.Length == 8 && int.TryParse(parts[0], out int number) && number == studentNumber);
            }).ToList();

            File.WriteAllLines(StudentFile, lines);
        }

        private const string SummaryFile = "summary.txt";

        public (int TotalStudents, double AverageAge) CalculateSummary()
        {
            int totalStudents = 0;
            int totalAge = 0;

            if (File.Exists(StudentFile))
            {
                var lines = File.ReadAllLines(StudentFile);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8 && int.TryParse(parts[4], out int age)) 
                    {
                        totalStudents++;
                        totalAge += age;
                    }
                }
            }

            double averageAge = totalStudents > 0 ? (double)totalAge / totalStudents : 0;
            return (totalStudents, averageAge);
        }

        
        public void SaveSummaryToFile(int totalStudents, double averageAge)
        {
            using (StreamWriter writer = new StreamWriter(SummaryFile, false))
            {
                writer.WriteLine($"Total Students: {totalStudents}");
                writer.WriteLine($"Average Age: {averageAge:F2}");
            }
        }

        public DataTable LoadSummaryFromFile()
        {
            DataTable summaryTable = new DataTable();
            summaryTable.Columns.Add("Summary Item", typeof(string));
            summaryTable.Columns.Add("Value", typeof(string));

            if (File.Exists(SummaryFile))
            {
                var lines = File.ReadAllLines(SummaryFile);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        DataRow row = summaryTable.NewRow();
                        row["Summary Item"] = parts[0].Trim();  
                        row["Value"] = parts[1].Trim();        
                        summaryTable.Rows.Add(row);
                    }
                }
            }
            return summaryTable;
        }
    }
}
