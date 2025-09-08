Ports-and-Adapters Example (.NET 7)
===================================

This project demonstrates the Ports and Adapters (Hexagonal) architecture pattern using .NET 7. It separates the core business logic from external systems through well-defined interfaces (ports) and adapters. The solution includes:

- CoreApplication: Implements business logic and communicates via inbound and outbound ports.
- InboundAdapter: Receives input and forwards it to the core application.
- OutboundAdapter: Handles output from the core application.
- Dependency Injection: Managed with Microsoft.Extensions.DependencyInjection.
- Unit tests: Provided with xUnit and Moq.

This structure makes the application flexible, testable, and easy to extend with new adapters or external integrations.
