namespace gregslist.Interfaces
{
    public interface IPurchasable
    {
        public float Price { get; set; }
        public string PaymentMethods { get; set; }

        public void Bid(float price);
    }
}