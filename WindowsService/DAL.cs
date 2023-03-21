using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public class DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        int ReturnValues;

        public DAL()
        {
            con = new SqlConnection("data source=DESKTOP-I299EIT\\SQLEXPRESS; initial catalog =OlayGunlugu; user Id = sa; password=123456;");
        }

        public int OlayGunluguYeniKayit(string Olay, DateTime OlusturmaTarihi)
        {
            try 
            {
                cmd = new SqlCommand("insert into OlayGunlugu (Olay, OlusturmaTarihi) values (@Olay, @OlusturmaTarihi)", con);
                cmd.Parameters.Add("@Olay", SqlDbType.NVarChar).Value = Olay;
                cmd.Parameters.Add("@OlusturmaTarihi", SqlDbType.DateTime).Value = OlusturmaTarihi;
                con.Open();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception) 
            {
 
            }
            finally
            {
                con.Close();
            }

            return ReturnValues;



        }

        
    }
}
