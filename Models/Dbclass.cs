using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Microservice.Models
{
    public class Dbclass
    {
        SqlConnection con = new SqlConnection("Data Source=CHARAN;Initial Catalog=CGIDatabase;Integrated Security=True");
        public int LoginCheck(Login ad)
        {
            /*  SqlCommand com = new SqlCommand("database", con);
              com.CommandType = CommandType.StoredProcedure;
              com.Parameters.AddWithValue("@UserName", ad.UserName);
              com.Parameters.AddWithValue("@Passcode", ad.Passcode);
              SqlParameter oblogin = new SqlParameter();
              oblogin.ParameterName = "@Isvalid";
              oblogin.SqlDbType = SqlDbType.Bit;
              oblogin.Direction = ParameterDirection.Output;
              com.Parameters.Add(oblogin);
              con.Open();
              com.ExecuteNonQuery();
              int res = Convert.ToInt32(oblogin.Value);
              con.Close();
              return res;*/
            CoreDbContext db = new CoreDbContext();
            var IsCorrect=db.Logins.Where(x => x.UserName == ad.UserName && x.Passcode == ad.Passcode).Any();
            return IsCorrect? 1:0;

        }
    }
}
