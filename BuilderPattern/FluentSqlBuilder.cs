using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BuilderPattern
{
    public class FluentSqlBuilder : 
        IServerSelectionState, 
        IDatabaseSelectionState,
        IUserSelectionStatege,
        IPasswordSelectionState,
        IConnectionInitializerState
    {
        private string Server;
        private string Database;
        private string User;
        private string Password;
        private string ConfigurationName;

        private FluentSqlBuilder(ConnectionConfiguration connectionConfiguration)
        {
            ConfigurationName = connectionConfiguration.ConnectionName;
        }

        public static IServerSelectionState CreateConnection(Action<ConnectionConfiguration> conf)
        {
            var connectionConfiguration = new ConnectionConfiguration();
            conf.Invoke(connectionConfiguration);
            return new FluentSqlBuilder(connectionConfiguration);
        }

        public class ConnectionConfiguration
        {
            public string ConnectionName { get; set; }
        }


        public IDatabaseSelectionState WithServer(string server)
        {
            Server = server;
            return this;
        }

        public IUserSelectionStatege WithUser(string user)
        {
            User = user;
            return this;
        }

        public IPasswordSelectionState WithPassword(string password)
        {
            Password = password;
            return this;
        }

        public IDbConnection Connect()
        {
            var connection = new SqlConnection();
            connection.Open();
            return connection;
        }

        IConnectionInitializerState IPasswordSelectionState.Connect()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IServerSelectionState
    {
        public IDatabaseSelectionState WithServer(string server);
    }

    public interface IDatabaseSelectionState
    {
        public IUserSelectionStatege WithUser(string user);
    }

    public interface IUserSelectionStatege
    {
        public IPasswordSelectionState WithPassword(string password);
    }

    public interface IPasswordSelectionState
    {
        public IConnectionInitializerState Connect();
    }

    public interface IConnectionInitializerState
    {
        public IDbConnection Connect();
    }
}