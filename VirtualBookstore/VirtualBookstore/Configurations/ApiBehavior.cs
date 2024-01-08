using Microsoft.AspNetCore.Mvc;

namespace VirtualBookstore.Api.Configurations
{
    public static class ApiBehavior
    {
        public static void ConfigureApiBehavior(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        }
    }
}
