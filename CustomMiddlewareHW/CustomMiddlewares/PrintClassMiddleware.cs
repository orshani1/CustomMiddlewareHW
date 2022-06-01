namespace CustomMiddlewareHW.CustomMiddlewares
{
    public class PrintClassMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync($"Class Number : {3}");
            await next(context);
       
        }
    }
}
