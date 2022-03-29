using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace TodosWebGraphQL.Models
{
    
    public class Offer
    {
        public Offer()
        {
            
        }
        public Offer(int userId, int price, string itemname, string itemquality, bool itemstatrack, bool itemstickers, string description)
        {
            UserId = userId;
            Price = price;
            Itemname = itemname;
            Itemquality = itemquality;
            Itemstatrack = itemstatrack;
            Itemstickers = itemstickers;
            Description = description;
        }
        
        
        //Hvem laver salget
        public int UserId { get; set; }
        
        //Generate selv
        public int OfferID { get; set; }
        
        //[Required, MaxLength(128)] 
        public int Price { get; set; }
        
        //Siden vi ikke selv fetcher i projektet - (indstast selv derfor)
        public string Itemname { get; set; }
        public string Itemquality { get; set; }
        public bool Itemstatrack { get; set; }
        public bool Itemstickers { get; set; }
        
        public string Description { get; set; }
        
    }
}