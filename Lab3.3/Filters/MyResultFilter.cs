using Lab3._3.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab3._3.Filters
{
    public class MyResultFilterAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            string controllerName = context.Controller.ToString();
            if (RequestCounter.Counters.ContainsKey(controllerName))
            {
                RequestCounter.Counters[controllerName]++;
            }
            else
            {
                RequestCounter.Counters.Add(controllerName, 1);
            }
            context.HttpContext.Response.Headers.Append("X-Controller-Requests", RequestCounter.Counters[controllerName].ToString());
        }
    }
}
