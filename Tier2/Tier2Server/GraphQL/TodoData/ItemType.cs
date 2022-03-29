using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using TodosWebGraphQL.Data;
using TodosWebGraphQL.Models;

namespace TodosWebGraphQL.GraphQL.TodoData
{
    
    public class ItemType : ObjectType<Todo>
    {
        protected override void Configure(IObjectTypeDescriptor<Todo> descriptor)
        {
            descriptor.Description("This model is used as a todo");
            descriptor.Field(x => x.Title)
                .Description("this is the todo title");
        }
        
        private class Resolvers
        {

            public IList<Todo> GetTodos(Todo todo,[Service] ITodoData context)
            {
                return (IList<Todo>) context.GetTodos().Where(x=> x.UserId.Equals(todo.UserId));
            }
            public IList<Offer> GetOffers(Offer offer,[Service] IOfferData context)
            {
                return (IList<Offer>) context.GetOffers().Where(x=> x.UserId.Equals(offer.UserId));
            }
        }
        
        
        
        
        
    }
    
    
}