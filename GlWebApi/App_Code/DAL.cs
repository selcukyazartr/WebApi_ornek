using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GlWebApi.App_Code
{
    public class DAL
    {
        public static int insertProcedureTsql(string tsql, List<SqlParameter> prms)
        {
            int returnValue = 0;
            string cnnStr = ConfigurationManager.ConnectionStrings["db"].ToString(); 
                                                                                     
            using (SqlConnection cn = new SqlConnection(cnnStr))
            {
                cn.Open();
                if (cn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = tsql;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 35000;

                    foreach (SqlParameter p in prms)

                        cmd.Parameters.Add(p);

                    cmd.ExecuteNonQuery();
                    //try
                    //{
                    //    returnValue = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);

                    //}
                    //catch{ }

                    cmd.Dispose();
                    cn.Close();
                    cn.Dispose();
                }
                else
                {
                    returnValue = -1;
                }
            }
            return returnValue;
        }
    }
}