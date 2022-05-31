using System;
using InmateTracker.Modeli;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace InmateTracker.Repozitorij
{
    internal class PromjeneOsobni
    {
       public static OsobniUredaj odabrani = new OsobniUredaj();
        public static void Vracanje(OsobniUredaj prosljedjeni)
        {
            odabrani = prosljedjeni;
        }

        public static void UnosOsobnog(OsobniUredaj osobni)
        {
            string unos = $"INSERT INTO Osobni_uredaji (Ime_vlasnika, Radio_signal, Broj_telefona) VALUES ('{osobni.Ime_vlasnika}','{osobni.Radio_signal}','{osobni.Broj_telefona}') ";
            DB.OpenConnection();
            DB.ExecuteCommand(unos);
            DB.CloseConnection();
        }
        public static void BrisanjeOsobnog(OsobniUredaj osobni)
        {
            string brisanje = $"DELETE  FROM Osobni_uredaji WHERE ID_uredaja = {osobni.ID_uredaja} ";
            DB.OpenConnection();
            DB.ExecuteCommand(brisanje);
            DB.CloseConnection();
        }
        public static void UrediOsobnog(string ime, string signal, string telefon)
        { 
            string uredi = $"UPDATE Osobni_uredaji SET Ime_vlasnika = '{ime}',  Radio_signal = '{signal}',  Broj_telefona = '{telefon}' WHERE '{odabrani.ID_uredaja}' = ID_uredaja";
            DB.OpenConnection();
            DB.ExecuteCommand(uredi);
            DB.CloseConnection();
        }

       

    }
}
