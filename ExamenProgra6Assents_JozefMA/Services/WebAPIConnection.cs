using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra6Assents_JozefMA.Services
{
    internal class WebAPIConnection
    {

        public static string ProductionURLPrefix = "http://192.168.0.5:45455/swagger/";

        public static string TestingURLPrefix = "http://192.168.0.5:45455/swagger/";

        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "JozefDP6Apik1234";

        public static string MimeType = "application/json";
        public static string ContentType = "Content-Type";

    }
}
