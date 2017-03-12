using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Enter_Student_Details
{
    class DBClass
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Hp/Documents/DataBases/priDB.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        public bool registerStudent(Student student)
        {
            //SQL STMT
            const string sql = "INSERT INTO studentsTB(firstname,middlename,lastname,dob) VALUES(@FNAME,@MNAME,@LNAME,@DOB)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@FNAME", student.Firstname);
            cmd.Parameters.AddWithValue("@MNAME", student.Middlename);
            cmd.Parameters.AddWithValue("@LNAME", student.Lastname);
            cmd.Parameters.AddWithValue("@DOB", student.Dob.ToShortDateString());


            //OPEN CON AND EXEC
            try
            {
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {

                    return true;

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}
