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
        private const string StudentFile = "students.txt";
        private const string SummaryFile = "summary.txt";

        public void WriteToFile(string email, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Email or password cannot be null or empty.");
                }

                using (StreamWriter writer = new StreamWriter(UserFile, true))
                {
                    writer.WriteLine(email + "," + password);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to file: {ex.Message}");
            }
        }

        public string ReadFromFile(string email, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Email or password cannot be null or empty.");
                }

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
                                return "Successful";
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
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return "Error occurred during authentication.";
            }
        }

        public DataTable ReadAllStudents()
        {
            try
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
                else
                {
                    throw new FileNotFoundException("Student file not found.");
                }

                return studentTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading students: {ex.Message}");
                return new DataTable(); // Return empty DataTable in case of error
            }
        }

        public void WriteStudentToFile(Student student)
        {
            try
            {
                if (student == null)
                {
                    throw new ArgumentNullException(nameof(student), "Student cannot be null.");
                }

                using (StreamWriter writer = new StreamWriter(StudentFile, true))
                {
                    writer.WriteLine($"{student.StudentNumber},{student.FirstName},{student.LastName},{student.DateOfBirth:yyyy-MM-dd},{student.Age},{student.Gender},{student.Phone},{student.Address}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing student data: {ex.Message}");
            }
        }

        public void UpdateStudentInFile(Student updatedStudent)
        {
            try
            {
                if (!File.Exists(StudentFile))
                {
                    throw new FileNotFoundException("Student file not found.");
                }

                var lines = File.ReadAllLines(StudentFile).ToList();
                bool studentUpdated = false;
                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(',');
                    if (parts.Length == 8 && int.TryParse(parts[0], out int studentNumber) && studentNumber == updatedStudent.StudentNumber)
                    {
                        lines[i] = $"{updatedStudent.StudentNumber},{updatedStudent.FirstName},{updatedStudent.LastName},{updatedStudent.DateOfBirth:yyyy-MM-dd},{updatedStudent.Age},{updatedStudent.Gender},{updatedStudent.Phone},{updatedStudent.Address},{updatedStudent.Course}";
                        studentUpdated = true;
                        break;
                    }
                }

                if (studentUpdated)
                {
                    File.WriteAllLines(StudentFile, lines);
                }
                else
                {
                    throw new InvalidOperationException("Student not found in file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating student data: {ex.Message}");
            }
        }

        public void DeleteStudentFromFile(int studentNumber)
        {
            try
            {
                if (!File.Exists(StudentFile))
                {
                    throw new FileNotFoundException("Student file not found.");
                }

                var lines = File.ReadAllLines(StudentFile).ToList();
                lines = lines.Where(line =>
                {
                    var parts = line.Split(',');
                    return !(parts.Length == 8 && int.TryParse(parts[0], out int number) && number == studentNumber);
                }).ToList();

                File.WriteAllLines(StudentFile, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting student data: {ex.Message}");
            }
        }

        public (int TotalStudents, double AverageAge) CalculateSummary()
        {
            try
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
                else
                {
                    throw new FileNotFoundException("Student file not found.");
                }

                double averageAge = totalStudents > 0 ? (double)totalAge / totalStudents : 0;
                return (totalStudents, averageAge);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while calculating summary: {ex.Message}");
                return (0, 0); // Return 0 if error occurs
            }
        }

        public void SaveSummaryToFile(int totalStudents, double averageAge)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(SummaryFile, false))
                {
                    writer.WriteLine($"Total Students: {totalStudents}");
                    writer.WriteLine($"Average Age: {averageAge:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving summary to file: {ex.Message}");
            }
        }

        public DataTable LoadSummaryFromFile()
        {
            try
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
                else
                {
                    throw new FileNotFoundException("Summary file not found.");
                }

                return summaryTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading summary from file: {ex.Message}");
                return new DataTable(); // Return empty DataTable in case of error
            }
        }
    }
}
