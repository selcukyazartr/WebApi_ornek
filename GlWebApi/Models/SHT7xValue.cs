using System.Collections.Generic;
using System.Data.SqlClient;
using GlWebApi.App_Code;

namespace GlWebApi.Models
{
    public class SHT7xValue
    {
        public string NodId { get; set; }
        public string NodAddress { get; set; }
        public string sensorID { get; set; }
        public string sensorValue { get; set; }
        public string rssi { get; set; }      
        public string dname { get; set; }



        public int DBEkle()
        {            
            return DAL.insertProcedureTsql("INSERT INTO SHTValues VALUES (@NODADRES, @NodeId, @sensorID, @sensorValue,@rssi,@dname,GETDATE())", new List<SqlParameter>() {
             new SqlParameter(){ParameterName="@NODADRES",Value=this.NodAddress},
            new SqlParameter(){ParameterName="@NodeId",Value=this.NodId},
            new SqlParameter(){ParameterName="@sensorID",Value=this.sensorID},
             new SqlParameter(){ParameterName="@sensorValue",Value=this.sensorValue},
             new SqlParameter(){ParameterName="@rssi",Value=this.rssi},             
             new SqlParameter(){ParameterName="@dname",Value=this.dname},
            });
        }
    }
}