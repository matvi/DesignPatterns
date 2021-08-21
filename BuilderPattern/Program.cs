using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentSqlBuilder.CreateConnection(config =>
                {
                    config.ConnectionName = "David connection";
                })
                .WithServer("localhost")
                .WithUser("david")
                .WithPassword("password")
                .Connect();
        }
    }
}