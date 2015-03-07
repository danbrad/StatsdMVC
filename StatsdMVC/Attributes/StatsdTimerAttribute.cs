using StatsdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatsdMVC.Attributes
{
    public class StatsdTimerAttribute : ActionFilterAttribute
    {
        private Stopwatch stopWatch;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            stopWatch.Stop();

            var rd = filterContext.RequestContext.RouteData;
            string action = rd.GetRequiredString("action");
            string controller = rd.GetRequiredString("controller");
            string area = rd.Values["area"] as string;

            string key  = (string.IsNullOrEmpty(area) ? "NoArea" : area) + "." + controller + "." + action;
            int value = stopWatch.ElapsedMilliseconds();
            double samplerate = 1;

            Metrics.Timer(key, value, samplerate);
        }
    }
}