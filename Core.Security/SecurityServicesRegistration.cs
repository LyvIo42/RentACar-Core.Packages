using Core.Security.JWT;
using Core.Security.OtpAuthenticator;
using Core.Security.OtpAuthenticator.OtpNet;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Core.Security;

public static class SecurityServicesRegistration
{
    public static IServiceCollection AddSecurityServices(this IServiceCollection services)
    {
        services.AddScoped<ITokenHelper, jwtHelper>();
        // services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();
         return services;

    }
}
