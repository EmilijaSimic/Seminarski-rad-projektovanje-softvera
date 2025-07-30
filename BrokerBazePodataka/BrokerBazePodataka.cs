using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Transactions;
using Zajednicki.Domen;

namespace BazaPodataka
{
    public class BrokerBazePodataka
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void OtvoriKonekciju()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seminarski_rad;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                connection.Open();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>> Nije moguće povezati se sa bazom: " + ex.Message);
            }
        }

        public void ZatvoriKonekciju()
        {
            connection?.Close();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public bool PotvrdiTransakciju()
        {
            try
            {
                transaction.Commit();
            }
            catch (SqlException ex) {
                Debug.WriteLine(">>> " + ex.Message);
                return false;
            }
            return true;
        }

        public bool OdbaciTransakciju()
        {
            try
            {
                transaction.Rollback();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
                return false;
            }
            return true;
        }

        public List<OpstiDomenskiObjekat> VratiListuSvih(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> objekti = new List<OpstiDomenskiObjekat>();
            string upit = "SELECT * FROM " + odo.VratiNazivTabele();
            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                SqlDataReader ulaz = cmd.ExecuteReader();

                while (ulaz.Read())
                {
                    OpstiDomenskiObjekat objekat = odo.ProcitajRed(ulaz);
                    objekti.Add(objekat);
                }

                ulaz.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
            return objekti;
        }

        public bool Kreiraj(OpstiDomenskiObjekat odo)
        {
            string upit = "INSERT INTO " + odo.VratiNazivTabele() + " (" + odo.VratiNaziveKolona + ") output inserted.id VALUES (" + odo.VratiVrednostiKolona + ")";

            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                int id = (int)cmd.ExecuteScalar();
                //proveri ovo ispod OBAVEZNO
                var tip = odo.GetType();
                var prop = tip.GetProperty("Id");
                if (prop != null && prop.CanWrite)
                {
                    prop.SetValue(odo, id);
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
                return false;
            }
            return true;
        }
        public bool Promeni(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.VratiNazivTabele() + " SET " + odo.VratiVrednostiZaPromenu() + " WHERE " + odo.Uslov();

            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                int brojRedova = cmd.ExecuteNonQuery();
                if (brojRedova < 1)
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
                return false;
            }
            return true;
        }
        public bool Obrisi(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.VratiNazivTabele() + " WHERE " + odo.Uslov();
            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                int brojRedova = cmd.ExecuteNonQuery();
                if (brojRedova < 1)
                {
                    return false;
                }
            }
            catch (SqlException ex) {
                Debug.WriteLine(">>> " + ex.Message);
                return false;
            }
            return true;
        }

        public List<OpstiDomenskiObjekat> Pretrazi(OpstiDomenskiObjekat odo, string filter)
        {
            List<OpstiDomenskiObjekat> objekti = new List<OpstiDomenskiObjekat>();
            string upit = "SELECT * FROM " + odo.VratiNazivTabele() + " WHERE " + odo.UslovZaPretragu(filter);
            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                SqlDataReader ulaz = cmd.ExecuteReader();

                while (ulaz.Read())
                {
                    OpstiDomenskiObjekat objekat = odo.ProcitajRed(ulaz);
                    objekti.Add(objekat);
                }

                ulaz.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
            return objekti;
        }

        public List<OpstiDomenskiObjekat> VratiListuSvihSaJoin(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> objekti = new List<OpstiDomenskiObjekat>();
            string upit = "SELECT * FROM " + odo.VratiNazivTabele() + " " + odo.Join();
            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                SqlDataReader ulaz = cmd.ExecuteReader();

                while (ulaz.Read())
                {
                    OpstiDomenskiObjekat objekat = odo.ProcitajRed(ulaz);
                    objekti.Add(objekat);
                }

                ulaz.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
            return objekti;
        }

        public List<OpstiDomenskiObjekat> PretraziSaJoin(OpstiDomenskiObjekat odo, string filter)
        {
            List<OpstiDomenskiObjekat> objekti = new List<OpstiDomenskiObjekat>();
            string upit = "SELECT * FROM " + odo.VratiNazivTabele() + " " + odo.Join() + " WHERE " + odo.UslovZaPretragu(filter);
            try
            {
                SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Transaction = transaction;
                SqlDataReader ulaz = cmd.ExecuteReader();

                while (ulaz.Read())
                {
                    OpstiDomenskiObjekat objekat = odo.ProcitajRed(ulaz);
                    objekti.Add(objekat);
                }

                ulaz.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
            return objekti;
        }
    }
}
