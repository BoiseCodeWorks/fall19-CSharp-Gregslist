namespace gregslist.Models
{
    public abstract class Listing
    {
        // public string Condition { get; set; }
        // public string ImgUrl { get; set; }
        public string SubCategory { get; set; }
        // public int Year { get; set; }
        public string Description { get; set; }

        //NOTE creates a default method that can be overriden
        public virtual string GetTemplate()
        {
            string template = $@"
Image: {ImgUrl}
Year: {Year}
Description: {Description}
Condition: {Condition}
SubCategory: {SubCategory}

press any key to return to the main menu!";
            return template;
        }





        public Listing(int year, string desc, double price, string condition, string imgurl, string subcat)
        {
            Condition = condition;
            ImgUrl = imgurl;
            SubCategory = subcat;
            Year = year;
            Description = desc;
            // Price = price;
        }
    }
}