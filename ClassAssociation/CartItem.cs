namespace ClassAssociation
{
    class CartItem
    {
        public int Code {get;set;}
        public string Name {get;set;}

        public double Price {get;set;}

        public int Quantity {get;set;}

        public CartItem(){}

        public CartItem(int c, string n, double p,int q)
        {
            Code = c;
            Name = n;
            Price = p;
            Quantity = q;
        }

        public override string ToString()
        {
            return "Code: " + Code + "\tName: " + Name + "\tPrice " + Price + "\tQuantity: " + Quantity;
        }


    }
}