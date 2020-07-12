using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using Application.SeedWork.Behaviours;
using Application.SeedWork;
using FluentValidation;

namespace Application
{
    public static class ServiceInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));

            return services;
        }
    }
}
