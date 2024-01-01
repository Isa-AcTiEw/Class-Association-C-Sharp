using System.ComponentModel.DataAnnotations;

namespace ClassAssociation
{
    class ShoppingCart
    {
        public string CartId {get;set;}
        public List <CartItem> ItemList {get;set;}
                            = new List <CartItem>();

        public ShoppingCart(){}
        public ShoppingCart(string id)
        {
            CartId = id;
        }

        public void AddCart(CartItem ci)
        {
            ItemList.Add(ci);
        }
    }
}