﻿using Microsoft.Extensions.DependencyInjection;
using OnionExample.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmailService, EmailService>();
        }
    }
}
