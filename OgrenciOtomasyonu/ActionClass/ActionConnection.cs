using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OgrenciOtomasyonu.ActionClass
{
    public class ActionConnection
    {
        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UM4A0SV\\SQLEXPRESS;Initial Catalog=OgrenciOtomasyon;Integrated Security=True";
            return con;
        }
        public  static DataTable ExecuteReader(string sqlKod,string[] parametre,string[]deger)
        {
            SqlCommand kod = new SqlCommand();
            kod.Connection = Connection();
            kod.Connection.Open();
            kod.CommandText = sqlKod;
            for (int i = 0; i < parametre.Length; i++)
            {
                kod.Parameters.AddWithValue(parametre[i], deger[i]);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(kod);
            da.Fill(dt);
            kod.Connection.Close();
            return dt;
        }
        //public static DataTable GetExecuteReader(string sqlKod,string[]parametre,string[]deger)
        //{
        //    SqlCommand kod = new SqlCommand();
        //    kod.Connection = Connection();
        //    kod.Connection.Open();
        //    kod.CommandText = sqlKod;
        //    SqlDataReader rd = kod.ExecuteReader();
        //    while (rd.Read())
        //    {
        //        for (int i = 0; i < parametre.Length; i++)
        //        {
        //            kod.Parameters.AddWithValue(parametre[i], deger[i]);
        //        }
        //        break;
        //    }
        //    kod.Connection.Close();
        //    return rd;
        //}
        public static DataTable ExecuteReader(string sqlKod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= Connection();
            cmd.Connection.Open();
            cmd.CommandText = sqlKod;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }
        public static int ExecuteNonQuery(string sqlKod, string[] parametre, string[] deger)
        {
            int durum = 0;
            SqlCommand kod = new SqlCommand();
            kod.Connection = Connection();
            kod.Connection.Open();
            kod.CommandText = sqlKod;
            for (int i = 0; i < parametre.Length; i++)
            {
                kod.Parameters.AddWithValue(parametre[i], deger[i]);
            }
            durum = kod.ExecuteNonQuery();
            kod.Connection.Close();
            return durum;
        }
    }
}
