
using System;
using System.Data.SqlClient;
 
namespace Layer3

{

    public class Circle

    {

        public float pi { get; } = 3.14f;

        public float VolumeConstant { get; private set; }

        public float AreaConstant { get; private set; }

        public Circle()

        {

            RetrieveConstants();

        }

        private void RetrieveConstants()

        {

            string connectionString = "Data Source=192.168.0.30;Initial Catalog=EMPID#266;User ID=User5;Password=CDev005#8";

            string query = "SELECT AreaCon, VolumeCon FROM Shapes WHERE NameofShape = 'Sphere'";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())

                {

                    AreaConstant = Convert.ToSingle(reader["AreaCon"]);

                    VolumeConstant = Convert.ToSingle(reader["VolumeCon"]);

                }

            }

        }

    }


    public class OperationStore

    {

        public string Name { get; set; }

        public string Operation { get; set; }

        public void PrintStoredOperation()

        {

            Console.WriteLine($"Name: {Name}, Operation: {Operation}");

        }

        public static void Main(string[] args) { }

    }

}


