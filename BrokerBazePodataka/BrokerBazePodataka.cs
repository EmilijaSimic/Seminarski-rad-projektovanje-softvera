using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Transactions;

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

    }
}
