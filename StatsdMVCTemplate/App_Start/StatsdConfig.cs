using StatsdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StatsdMVCTemplate
{
    public static class StatsdConfig
    {
        public static void Register()
        {
            var metricsConfig = new MetricsConfig
            {
                StatsdServerName = "localhost",
                Prefix = "StatsdMVCTemplate",
                StatsdServerPort = 8125
            };

            StatsdClient.Metrics.Configure(metricsConfig);
        }
    }
}
