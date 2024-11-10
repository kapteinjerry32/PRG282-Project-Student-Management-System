using StudentManagementApp.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace StudentManagementApp.Data_Layer
{
    internal class DataHandler
    {
        string conn = "Server = (local); Initial Catalog = ProjectDB; Integrated Security = True";

        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable FetchStudData()
        {
            string query = "SELECT * FROM Student";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        adapter.SelectCommand = command;
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataTable FetchStudentModules(int studentNumber)//fetches particular student module based on choice of student number
        {
            string query = "SELECT Module.moduleCode, Module.moduleName, Student.firstName, Student.lastName " +
                   "FROM Module " +
                   "INNER JOIN StudentModule ON Module.moduleCode = StudentModule.moduleCode " +
                   "INNER JOIN Student ON StudentModule.studentNumber = Student.studentNumber " +
                   "WHERE Student.studentNumber = @studentNumber";
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentNumber", studentNumber);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void RegisterStud(Student student)//Register new student and his/ her information into database 
        {
            string query = $"INSERT INTO Student VALUES" +
                $"('{student.StudentNumber}', '{student.FirstName}', '{student.LastName}', '{student.DateOfBirth}', '{student.Age}', '{student.Gender}', '{student.Phone}', '{student.Address}')";
            
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateStud(Student student)//modifies particular information of student 
        {
            string query = $"UPDATE Student SET studentNumber = '{student.StudentNumber}', firstName = '{student.FirstName}', lastName = '{student.LastName}', dateOfBirth = '{student.DateOfBirth}', age = '{student.Age}', gender = '{student.Gender}', phoneNumber = '{student.Phone}', address = '{student.Address}' WHERE studentNumber = '{student.StudentNumber}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteStud(Student student)//Deletes student based on their ID from the database
        {
            string query = $"DELETE FROM Student WHERE studentNumber = '{student.StudentNumber}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable SearchStud(int stdNum)
        {
            string query = $"SELECT * FROM Student WHERE studentNumber = '{stdNum}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataTable FetchModData()
        {
            string query = "SELECT * FROM Module";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        adapter.SelectCommand = command;
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void RegisterMod(Module module)//Register new module 
        {
            string query = $"INSERT INTO Module VALUES" +
                $"('{module.ModuleCode}', '{module.ModuleName}', '{module.ModuleDesc}', '{module.Resources}')";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateMod(Module module)//Updates model to new module
        {
            string query = $"UPDATE Module SET moduleCode = '{module.ModuleCode}', moduleName = '{module.ModuleName}', moduleDesc = '{module.ModuleDesc}', resources = '{module.Resources}' WHERE moduleCode = '{module.ModuleCode}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteMod(Module module)//Deletes chosen module
        {
            string query = $"DELETE FROM Module WHERE moduleCode = '{module.ModuleCode}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable SearchMod(string modCode)//Search for chosen module based on the module code
        {
            string query = $"SELECT * FROM Module WHERE moduleCode = '{modCode}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
