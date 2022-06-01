using System.Collections.Generic;

namespace CustomMiddlewareHW.CustomMiddlewares
{
    public static class CustomMiddlewareExtensions
    {
      
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            

             return builder.UseMiddleware<PrintClassMiddleware>();
        }

    }
}
