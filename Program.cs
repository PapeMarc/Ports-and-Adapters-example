using Microsoft.Extensions.DependencyInjection;
using Ports_and_Adapters_example;

ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IOutboundPort, OutboundAdapter>();
serviceCollection.AddSingleton<CoreApp>(); 
serviceCollection.AddSingleton<InboundAdapter>();

ServiceProvider serviceProvider =  serviceCollection.BuildServiceProvider();

CoreApp coreApp = serviceProvider.GetRequiredService<CoreApp>();
IInboundPort inboundPort = serviceProvider.GetRequiredService<InboundAdapter>();

inboundPort.processInput("This is the Input.");