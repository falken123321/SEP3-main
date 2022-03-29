using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using TodosWebGraphQL.Data;
using TodosWebGraphQL.Models;

namespace TodosWebGraphQL.GraphQL
{
    public class Query
    {

        [UseFiltering]
        [UseSorting]
        
        public IList<Todo> GetTodos([Service] ITodoData context)
        {
            
            return context.GetTodos();
        }
        
        public IList<Offer> GetOffers([Service] IOfferData context)
        {
            return context.GetOffers();
        }
        
        








    }
}