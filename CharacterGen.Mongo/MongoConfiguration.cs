using System.Collections.Specialized;
using System.Configuration;

namespace CharacterGen.Mongo
{
    public class MongoConfiguration
    {
        private readonly NameValueCollection mongoConfigSection = (NameValueCollection)
            ConfigurationManager.GetSection("MongoConfig"); 

        public string ConnectionString => string.Format(mongoConfigSection["MongoConnectionString"], Username, Password);
        public string Username => mongoConfigSection["MongoUsername"];
        public string Password => mongoConfigSection["MongoPassword"];
    }
}