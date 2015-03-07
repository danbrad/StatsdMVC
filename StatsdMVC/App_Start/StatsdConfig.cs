using StatsdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StatsdMVC
{
    public static class StatsdConfig
    {
        public static void Register()
        {
            var metricsConfig = new MetricsConfig
            {
                StatsdServerName = "localhost",
                Prefix = "StatsdMVC",
                StatsdServerPort = 8125
            };

            StatsdClient.Metrics.Configure(metricsConfig);
        }
    }
}
