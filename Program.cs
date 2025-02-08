using Microsoft.Extensions.DependencyInjection;
using Ports_and_Adapters_example.CoreApp;
using Ports_and_Adapters_example.Infrastructure;

ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IInboundPort, InboundAdapter>();
serviceCollection.AddSingleton<IOutboundPort, OutboundAdapter>();
serviceCollection.AddSingleton<CoreApp>(); 

ServiceProvider serviceProvider =  serviceCollection.BuildServiceProvider();

CoreApp coreApp = serviceProvider.GetRequiredService<CoreApp>();
IInboundPort inboundPort = serviceProvider.GetRequiredService<IInboundPort>();

inboundPort.processInput("This is the Input.");