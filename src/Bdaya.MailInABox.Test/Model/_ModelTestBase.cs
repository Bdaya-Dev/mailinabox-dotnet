using System;
using System.Text.Json;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Extensions;
using Bdaya.MailInABox.Test.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bdaya.MailInABox.Test.Model;

public abstract class ModelTestBase
{
    
    protected readonly JsonSerializerOptions JsonSerializerOptions;

    protected ModelTestBase()
    {
        var serviceCollection = new ServiceCollection();
        var _ = new HostConfiguration(serviceCollection);
        JsonSerializerOptions = serviceCollection.BuildServiceProvider().GetRequiredService<JsonSerializerOptionsProvider>().Options;
    }

}