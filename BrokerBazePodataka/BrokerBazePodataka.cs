using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace BrokerBazePodataka
{
    public class BrokerBazePodataka
    {
        private SqlConnection connection;

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

    }
}
