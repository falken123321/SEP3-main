using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using TodosWebGraphQL.Models;

namespace TodosWebGraphQL.GraphQL
{
    public class Subscription
    {
        
        
        
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<Todo>> OnTodoCreate([Service] ITopicEventReceiver eventReceiver,
            CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, Todo>("TodoCreated", cancellationToken);
        }
        
        
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<Todo>> OnTodoGet([Service] ITopicEventReceiver eventReceiver,
            CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, Todo>("ReturnedTodo", cancellationToken);
        }
    }
        
        
        
        
        
        
        
        
        
    }
