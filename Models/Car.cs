using gregslist.Interfaces;

namespace gregslist.Models
{
    public class Car : Manufactured, IPurchasable
    {
        public string Fuel { get; set; }
        public float Price { get; set; }
        public string PaymentMethods { get; set; }

        public bool HaveMechanicChecked()
        {
            return true;
        }

        //NOTE overrides the virtual in its parent (Polymorphism)
        public override string GetTemplate()
        {
            return $@"
Make: {Make}
Model: {Model}
Fuel: {Fuel}
Image: {ImgUrl}
Year: {Year}
Description: {Description}
Condition: {Condition}
SubCategory: {SubCategory}

press any key to return to the main menu!
            ";
        }

        public void Bid(float price)
        {
            if (price > 99)
            {
                Price += price;
            }
        }

        public Car(string make, string model, int year, string desc, double price, string condition, string imgurl, string subcat, string fuel) : base(make, model, year, desc, price, condition, imgurl, subcat)
        {
            Fuel = fuel;
            ImgUrl = @"
--- .-'--`-._
--- '-O---O--'";
        }
    }
}




// $@"
// Make: {c.Make}
// Model: {c.Model}
// Year: {c.Year}
// Price: {c.Price:c}
// Description: {c.Description}

// press any key to return to the main menu!