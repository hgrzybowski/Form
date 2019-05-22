using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Formularz.Config
{
    public class ConfigInitializer : CreateDatabaseIfNotExists<ConfigContext>
    {
        protected override void Seed(ConfigContext context)
        {
            base.Seed(context);
        }
    }
}