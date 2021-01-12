using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Login_Verification
{
    class ClassConnection
    {
        public static bool isVerified = false;
        public string ID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public static MySqlConnection connection() {
            MySqlConnection conn = new MySqlConnection();
            String strConn = "server=localhost;";
            strConn += "user=root;";
            strConn += "database=VerificationDB;";
            strConn += "sslmode=none;";

            conn.ConnectionString = strConn;
            conn.Open();
            return conn;
        
        }
        public void Register() {

            int i;
            MySqlConnection con = ClassConnection.connection();
            if (con.State == System.Data.ConnectionState.Closed) return;

            String verify = "SELECT * FROM user_tbl WHERE Username = ?";
            MySqlCommand cmdv = con.CreateCommand();
            cmdv.CommandText = verify;
            cmdv.Parameters.AddWithValue("username", this.username);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdv);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            MySqlDataReader reader = cmdv.ExecuteReader();
            while (reader.Read()) {

                i = i + 1;
            }if (i == 0)
            {


                MySqlConnection conn = ClassConnection.connection();
                if (conn.State == System.Data.ConnectionState.Closed) return;
                String sql = "INSERT INTO user_tbl(firstname,lastname,username,password,role)";
                sql += "VALUES(?,?,?,?,?)";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("firstname", this.firstname);
                cmd.Parameters.AddWithValue("lastname", this.lastname);
                cmd.Parameters.AddWithValue("username", this.username);
                cmd.Parameters.AddWithValue("password", this.password);
                cmd.Parameters.AddWithValue("role", this.role);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Register");
                cmd.Dispose();
                conn.Close();
            }
            else {
                MessageBox.Show("Username is not available");
            
            }





            
        }
        public void displayData() {
            MySqlConnection conn = ClassConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;

            string sql = "SELECT * FROM user_tbl WHERE username = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("username",this.username);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {

                ID = reader["id"].ToString();
                firstname = reader["firstname"].ToString();
                lastname = reader["lastname"].ToString();
                role = reader["role"].ToString();
               
            
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }
        public void Login() {

            int i;
            String userRole = String.Empty;
            MySqlConnection conn = ClassConnection.connection();
            if (conn.State == System.Data.ConnectionState.Closed) return;

            String verify = "SELECT * FROM user_tbl WHERE username = ? AND password = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = verify;
            cmd.Parameters.AddWithValue("username",this.username);
            cmd.Parameters.AddWithValue("password",this.password);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                i = i + 1;
                userRole = reader["role"].ToString();
            }
            if (i == 0)
            {
                //MessageBox.Show("Incorrect Username and Password");
                isVerified = false;
            }
            else {
                if (userRole.Equals("Administrator"))
                {
 
                    isVerified = true;
                   
                }
                else {
                    //MessageBox.Show("user");
                    isVerified = true;
                }
                
            }
        }
    }
}
