using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PostingManagement.Application.Contracts.Infrastructure;
using PostingManagement.Application.Models.Mail;
using PostingManagement.Infrastructure.Mail;

namespace PostingManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient<IEmailService, EmailService>();
            return services;
        }
    }
}
