using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TodosWebGraphQL.Models;


namespace TodosWebGraphQL.Data
{
    public class OfferData : IOfferData
    {
        private IList<Offer> Offers;

        public OfferData()
        {
            Seed();
        }

        private void Seed()
        {
            Offer[] ts =
            {
                new Offer {UserId = 1, Price = 1232, Itemname = "Do dishes", Itemstatrack = false},
                new Offer {UserId = 1, Price = 222, Itemname = "Walk the dog", Itemstatrack = false},
                new Offer {UserId = 2, Price = 311, Itemname = "Do DNP homework", Itemstatrack = true},
                new Offer {UserId = 3, Price = 455, Itemname = "Eat breakfast", Itemstatrack = false},
                new Offer {UserId = 4, Price = 522, Itemname = "Mow lawn", Itemstatrack = true},
            };
            Offers = ts.ToList();
        }
        
        public IList<Offer> GetOffers()
        {
            List<Offer> tmp = new List<Offer>(Offers);
            return tmp;
        }

        public async Task<Offer> AddOffer(Offer offer)
        {
            int maxID = Offers.Max(offer => offer.OfferID);
            offer.OfferID = (++maxID);
            Offers.Add(offer);

            return offer;
        }

        public Offer Get(int id)
        {
            return Offers.FirstOrDefault(i => i.OfferID == id);
        }
    }
}