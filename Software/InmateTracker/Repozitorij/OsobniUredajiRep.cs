using System;
using DBLayer;
using InmateTracker.Modeli;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InmateTracker.Repozitorij
{
    internal class OsobniUredajiRep
    {
        public static OsobniUredaj GetOsobni1()
        {
            OsobniUredaj osobni = null;

            string sql = $"SELECT * FROM Osobni_uredaji";
            DB.SetConfiguration("abrkovic20_DB", "abrkovic20", "[[9{y#W_");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                osobni = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return osobni;
        }
        public static List<OsobniUredaj> GetOsobni2()
        {
            List<OsobniUredaj> osobnis = new List<OsobniUredaj>();

            string sql = "SELECT * FROM Osobni_uredaji";
            DB.SetConfiguration("abrkovic20_DB", "abrkovic20", "[[9{y#W_");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                OsobniUredaj osobni = CreateObject(reader);
                osobnis.Add(osobni);

            }

            reader.Close();
            DB.CloseConnection();

            return osobnis;
        }

        private static OsobniUredaj CreateObject(SqlDataReader reader)
        {
            int ID_uredaja = int.Parse(reader["ID_uredaja"].ToString());
            string Ime_vlasnika = reader["Ime_vlasnika"].ToString();
            string Radio_signal = reader["Radio_signal"].ToString();
            string Broj_telefona = reader["Broj_telefona"].ToString();

            var osobni = new OsobniUredaj

            {
                ID_uredaja = ID_uredaja,
                Ime_vlasnika = Ime_vlasnika,
                Radio_signal = Radio_signal,
                Broj_telefona = Broj_telefona
            };

            return osobni;


        }
    }
}