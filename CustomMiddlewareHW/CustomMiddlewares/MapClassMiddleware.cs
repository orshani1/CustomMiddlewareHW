namespace CustomMiddlewareHW.CustomMiddlewares
{
    public class MapClassMiddleware : IMiddleware
    {
        public  async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
           await next(context);
        }
    }
}
