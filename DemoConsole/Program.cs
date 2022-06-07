// Copyright (c) Kaylumah, 2022. All rights reserved.
// See LICENSE file in the project root for full license information.

using Microsoft.Extensions.Configuration;

IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddEnvironmentVariables("KAYLUMAH_");
if (args is { Length: > 0 })
{
    configurationBuilder.AddCommandLine(args);
}
var configuration = configurationBuilder.Build();

if (configuration is IConfigurationRoot configurationRoot)
{
    Console.WriteLine(configurationRoot.GetDebugView());
}

Console.WriteLine("Done...");
Console.ReadLine();
