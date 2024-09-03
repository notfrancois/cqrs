# PiscesMetadata.CQRS

PiscesMetadata.CQRS is a lightweight C# library designed to facilitate efficient implementation of the Command Query Responsibility Segregation (CQRS) pattern in Domain-Driven Design (DDD) projects.

## Features

-   Streamlined CQRS implementation
-   Robust support for events and commands
-   Seamless MongoDB integration for event storage
-   Abstract base classes for queries and commands
-   Full compatibility with .NET 8.0

## Installation

You can install PiscesMetadata.CQRS via the NuGet Package Manager:

```bash
dotnet add package PiscesMetadata.CQRS
```

## Usage

### Basic Concepts

#### Command

A command is an instruction to perform a specific action. It is used to change the state of the system.

#### Query

A query is a request for information. It is used to read the state of the system.

#### Event

An event is a record of an action that has occurred in the system. It is used to maintain a history of actions and to notify other parts of the system of changes.

### Implementing Commands and Queries

#### Command

```csharp
public class CreateUserCommand(string name, string email, string password) : Command
{
    public override bool Validate()
    {
        return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
    }

    public override void Execute()
    {
        // Implementation of the command logic
    }
}
```

#### Query

```csharp
public class GetUserQuery(string userId) : Query
{
    public override bool Validate()
    {
        return !string.IsNullOrEmpty(userId);
    }

    public override object Execute()
    {
        // Implementation of the query logic
        return new { Name = "John Doe", Email = "john.doe@example.com" };
    }
}
```

### Event

```csharp
public class UserCreatedEvent(string userId, string name, string email) : Event
{
    public string UserId { get; set; } = userId;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
}
```

### Implementing Event Handlers

```csharp
public class UserEventHandler
{
    public void Handle(UserCreatedEvent event)
    {
        // Implementation of the event handler logic
    }
}
```

### Implementing Command Handlers

```csharp
public class UserCommandHandler
{
    public void Handle(CreateUserCommand command)
    {
        // Implementation of the command handler logic
    }
}
```

### Implementing Query Handlers

```csharp
public class UserQueryHandler
{
    public object Handle(GetUserQuery query)
    {
        // Implementation of the query handler logic
        return query.Execute();
    }
}
```

### Implementing Event Store

```csharp
public class UserEventStore
{
    public void Save(UserCreatedEvent event)
    {
        // Implementation of the event store logic
    }
}
```

# License

This project is licensed under the MIT License. See the [LICENSE](../LICENSE) file for more details.
