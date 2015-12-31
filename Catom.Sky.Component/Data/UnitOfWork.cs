using System.Data;
using MySql.Data.MySqlClient;

namespace Catom.Sky.Component.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbConnection Connection { private set; get; }

        public UnitOfWork(string connString)
        {
            Connection = new MySqlConnection(connString);
        }

        // 打开连接
        public void Open()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public void Close()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public void Dispose()
        {
            Close();
            Connection.Dispose();
        }
    }
}
