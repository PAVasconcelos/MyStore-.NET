using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Utility
{
    public class MailJetSettings
    {
        //Names match with the appsettings.json
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
    }
}
