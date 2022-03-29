using System.Collections.Generic;
using System.Threading.Tasks;
using TodosWebGraphQL.Models;

namespace TodosWebGraphQL.Data
{
    public interface IOfferData
    {
        IList<Offer> GetOffers();
        Offer Get(int id);
        Task<Offer> AddOffer(Offer offer);
    }
}