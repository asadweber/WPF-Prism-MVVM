using AppConfig.HelperClasses;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace AppConfig.ConfigDAAC
{
    public class AppConfiguration
    {
        public readonly string _connectionString = string.Empty;
        public readonly string _saltString = string.Empty;
        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            _connectionString = root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            _saltString = root.GetSection("AuthSettings").GetSection("SecretKey").Value;
        }
        public string ConnectionString
        {
            get => _connectionString;
        }

        public string SaltString
        {
            get => _saltString;
        }
    }
}
