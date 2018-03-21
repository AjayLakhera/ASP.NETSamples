using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SampleApp2
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String RegisterdNumber { get; set; }
        public String StudentCategory { get; set; }

        public static List<Student> list = new List<Student>();

        public bool AddStudent()
        {
            string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                string InsertStmt = "Insert into Student(Name,RegisteredNumber,Category)" +
                    "values(@Name,@RegisterdNumber,@Category);" +
                    "SELECT SCOPE_IDENTITY()";

                SqlCommand sql = new SqlCommand(InsertStmt, con);
                sql.Parameters.AddWithValue("@Name", this.Name);
                sql.Parameters.AddWithValue("@RegisterdNumber", this.RegisterdNumber);
                sql.Parameters.AddWithValue("@Category", this.StudentCategory);
                //sql.ExecuteNonQuery(); for single insert/delete/updte
                int ret = int.Parse(sql.ExecuteScalar().ToString());
                this.Id = ret;

            }
            catch (Exception exp)
            {
                Console.WriteLine($"Exception :- {exp.Message} ");
                throw;
            }

            return true;
        }
        public void GetStudent()
        {
            string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                string InsertStmt = "select * from Student";

                SqlCommand sql = new SqlCommand(InsertStmt, con);

                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student();
                    s.Id = (int)reader["Id"];
                    s.Name = (String)reader["Name"];
                    if (!string.IsNullOrEmpty(reader["Category"].ToString()))
                    {
                        s.StudentCategory = (String)reader["Category"];
                    }
                    s.RegisterdNumber = (string)reader["RegisteredNumber"];
                    list.Add(s);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Exception :- {exp.Message} ");
                throw;
            }
        }

        public static int GetTotalStudent()
        {
            int totalstd = 0;
            string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                string InsertStmt = "select count(*) from Student";

                SqlCommand sql = new SqlCommand(InsertStmt, con);

                totalstd = int.Parse(sql.ExecuteScalar().ToString());

            }
            catch (Exception exp)
            {
                Console.WriteLine($"Exception :- {exp.Message} ");
                throw;
            }

            return totalstd;
        }

        public static DataTable GetDataList()
        {
            string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            DataTable StudentTables = new DataTable("TestName");
            SqlConnection con = new SqlConnection(constr);

            try
            {
                // con.Open(); SqlDataAdapter automaticly open and close connection so need these stmt
                string InsertStmt = "select * from Student";

                SqlCommand sql = new SqlCommand(InsertStmt, con);

                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                adapter.Fill(StudentTables);

            }
            catch (Exception exp)
            {
                Console.WriteLine($"Exception :- {exp.Message} ");
                throw;
            }

            return StudentTables;
        }

        public Student GetStudentDetails()
        {
            Student stobj = new Student();
            string constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                string InsertStmt = "select * from Student";

                SqlCommand sql = new SqlCommand(InsertStmt, con);

                sql.Parameters.AddWithValue("@Id", this.Id);

                SqlDataReader reader = sql.ExecuteReader();

                stobj.Id = (int)reader["Id"];
                stobj.Name = (String)reader["Name"];
                stobj.RegisterdNumber = (string)reader["RegisteredNumber"];
                stobj.StudentCategory = (string)reader["Category"];

            }
            catch (Exception exp)
            {
                Console.WriteLine($"Exception :- {exp.Message} ");
                throw;
            }

            return stobj;
        }
    }
}
