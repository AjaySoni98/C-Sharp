using System.Data.SqlClient; //this is used for sql server not mysql server

namespace SQLBeginner{
    public class DBConnection{
        public SqlConnection GetConnection(){

            string connString = "SERVER=localhost;DATABASE=student;UID=root,PASSWORD='';";
            SqlConnection conn = new SqlConnection(connString);
            return conn;

        }
    }
}