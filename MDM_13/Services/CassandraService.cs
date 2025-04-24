using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using static System.Collections.Specialized.BitVector32;

namespace MDM_13.Services
{
    public static class CassandraService
    {
        private static ISession _session;

        public static void Initialize()
        {
            var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _session = cluster.Connect("mdm");
        }

        public static void InsertAccountLog(string userId)
        {
            _session.Execute(@"
                CREATE TABLE IF NOT EXISTS AccountLog (
                    userId TEXT,
                    loggedIn_at TIMESTAMP,
                    PRIMARY KEY (userId, loggedIn_at)
                );
            ");

            var ps = _session.Prepare("INSERT INTO AccountLog (userId, loggedIn_at) VALUES (?, ?)");
            var statement = ps.Bind(userId, DateTime.UtcNow);
            _session.Execute(statement);
        }
    }
}
