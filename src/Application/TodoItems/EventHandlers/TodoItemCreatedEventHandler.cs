using ca_angular.Domain.Events;
using Microsoft.Extensions.Logging;

namespace ca_angular.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ca_angular Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
