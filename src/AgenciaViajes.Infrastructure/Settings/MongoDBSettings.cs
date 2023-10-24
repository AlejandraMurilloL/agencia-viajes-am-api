using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Infrastructure.Settings
{
    public class MongoDBSettings
    {
        public const string SettingName = "MongoDBSettings";
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}
