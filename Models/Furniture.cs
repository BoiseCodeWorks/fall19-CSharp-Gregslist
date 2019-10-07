using gregslist.Interfaces;

namespace gregslist.Models
{
    public class Furniture : Listing, IPurchasable, IPhysical
    {

        public Furniture(int year, string desc, double price, string condition, string imgurl, string subcat) : base(year, desc, price, condition, imgurl, subcat)
        {
        }

        public float Price { get; set; }
        public string PaymentMethods { get; set; }
        public string ImgUrl { get; set; }
        public string Condition { get; set; }
        public int Year { get; set; }

        public void Bid(float price)
        {
            if (price > 49)
            {
                Price += price;
            }
        }
    }
}