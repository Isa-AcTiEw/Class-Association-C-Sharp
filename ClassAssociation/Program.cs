using ClassAssociation;
ShoppingCart myCart = new ShoppingCart();
myCart.AddCart(new CartItem(1,"Logitech Mouse",40.00,2));
myCart.AddCart(new CartItem(2,"Iphone 15",1350.00,1));
myCart.AddCart(new CartItem(3,"Sony XM4",380.00,1));
List <CartItem> itemList = myCart.ItemList;
double total = 0;
foreach(CartItem item in itemList)
{
    Console.WriteLine(item.ToString());
    double Price = item.Price * item.Quantity;
    total += Price;
    
}

Console.WriteLine($"Total Price is: {total}");
