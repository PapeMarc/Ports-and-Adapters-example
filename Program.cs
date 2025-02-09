using Microsoft.Extensions.DependencyInjection;
using Ports_and_Adapters_example.CoreApp;
using Ports_and_Adapters_example.Infrastructure;

ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IInboundPort, CoreApplication>();
serviceCollection.AddSingleton<InboundAdapter>();
serviceCollection.AddSingleton<IOutboundPort, OutboundAdapter>();

ServiceProvider serviceProvider =  serviceCollection.BuildServiceProvider();

InboundAdapter inboundAdapter= serviceProvider.GetRequiredService<InboundAdapter>();

inboundAdapter.handleInput("This is the Input.");