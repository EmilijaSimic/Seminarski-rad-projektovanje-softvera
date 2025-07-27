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
                return false;
            }
            return true;
        }

        public List<OpstiDomenskiObjekat> VratiListuSvih(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.VratiNazivTabele();
            SqlCommand cmd = new SqlCommand(upit, connection);
            SqlDataReader ulaz = cmd.ExecuteReader();
            List<OpstiDomenskiObjekat> objekti = new List<OpstiDomenskiObjekat>();

            while (ulaz.Read()) {
                OpstiDomenskiObjekat objekat = odo.ProcitajRed(ulaz);
                objekti.Add(objekat);
            }

            ulaz.Close();
            return objekti;
        }

    }
}
