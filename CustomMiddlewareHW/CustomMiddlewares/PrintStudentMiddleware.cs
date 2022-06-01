namespace CustomMiddlewareHW.CustomMiddlewares
{
    public class PrintStudentMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync($"Student Number : {51}");
            await next(context);
            
        }
    }
}
