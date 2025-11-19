using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLSIU
{

    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;

        private SqlCommand slqCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString = "Server = LAB-A-PC00; Database=ClubDBadi;User Id = paunillan.a; Password=12345;";
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            sqlConnect = new SqlConnection(connectionString);

            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public void OpenConnection()
        {
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        public void CloseConnection()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
        }

        public bool DisplayList()
        {
            try
            {              
                string ViewClubMembers =
                    "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program " +
                    "FROM ClubMembers";
                
                sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
            
                dataTable.Clear();
                sqlAdapter.Fill(dataTable);
             
                bindingSource.DataSource = dataTable;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName,
              string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            try
            {
                string insertQuery =
                    "INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program) " +
                    "VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)";

                slqCommand = new SqlCommand(insertQuery, sqlConnect);

                slqCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                slqCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                slqCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                slqCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                slqCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                slqCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                slqCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                slqCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                OpenConnection();
                slqCommand.ExecuteNonQuery();
                CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<long> GetAllStudentIDs()
        {
            List<long> studentIDs = new List<long>();

            try
            {
                OpenConnection();

                string query = "SELECT StudentId FROM ClubMembers";
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    studentIDs.Add(reader.GetInt64(0)); 
                }

                reader.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Student IDs: " + ex.Message);
            }

            return studentIDs;
        }

        public DataRow GetStudentByID(long studentID)
        {
            DataTable dt = new DataTable();

            try
            {
                OpenConnection();

                string query = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program " +
                               "FROM ClubMembers WHERE StudentId = @StudentId";

                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                cmd.Parameters.AddWithValue("@StudentId", studentID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                CloseConnection();

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student info: " + ex.Message);
                return null;
            }
        }


    }
}
