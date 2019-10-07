using gregslist.Interfaces;

namespace gregslist.Models
{
    public abstract class Manufactured : Listing, IPhysical
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string ImgUrl { get; set; }
        public string Condition { get; set; }
        public int Year { get; set; }

        public override string GetTemplate()
        {
            return "";
        }
        public Manufactured(string make, string model, int year, string desc, double price, string condition, string imgurl, string subcat) : base(year, desc, price, condition, imgurl, subcat)
        {
            Make = make;
            Model = model;
        }
    }
}