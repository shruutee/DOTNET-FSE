using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab3_WebAPI_CustomModel_Filters.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            string path = "ErrorLog.txt";

            File.AppendAllText(path,
                DateTime.Now +
                Environment.NewLine +
                context.Exception.Message +
                Environment.NewLine +
                "---------------------" +
                Environment.NewLine);

            context.Result = new ObjectResult(context.Exception.Message)
            {
                StatusCode = 500
            };
        }
    }
}
