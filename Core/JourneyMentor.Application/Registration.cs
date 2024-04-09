using JourneyMentor.Application.Bases;
using JourneyMentor.Application.Beheviors;
using JourneyMentor.Application.Exceptions;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;
using JourneyMentor.Application.DTOs;

namespace JourneyMentor.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services,IConfiguration configuration)
        {

            var aviationStackSettings = configuration.GetSection("AviationStackDataForFlights");
            AviationStackDataForFlights.ApiUrl = aviationStackSettings["ApiUrl"];
            AviationStackDataForFlights.AccessKey = aviationStackSettings["AccessKey"];

            var aviationStackSettingsForAirport = configuration.GetSection("AviationStackDataForAirport");
            AviationStackDataForAirport.ApiUrl = aviationStackSettings["ApiUrl"];
            AviationStackDataForAirport.AccessKey = aviationStackSettings["AccessKey"];

            var assembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleware>();

            services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RedisCacheBehevior<,>));


        }

        private static IServiceCollection AddRulesFromAssemblyContaining(
            this IServiceCollection services,
            Assembly assembly,
            Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }
    }
}