// See https://aka.ms/new-console-template for more information

using productsConsume;
#region 1. View All Products
//Console.WriteLine("1. View All Products");
//productDetails productData = new productDetails();
//var data = productData.ConsumeAllProducts();

//foreach (var i in data)
//{
//    Console.WriteLine($"Product ID: {i.pId}");
//    Console.WriteLine($"Product Name: {i.pName}");
//    Console.WriteLine($"Product Price: {i.pPrice}");
//    Console.WriteLine($"Available Quantity: {i.pAvailableQty}");
//    Console.WriteLine($"Description: {i.pDescription}");
//    Console.WriteLine($"Stock Availability Status: {i.pIsInStock}");
//    Console.WriteLine("~~~~~~~~~~");

//}

#endregion

#region 2. Search Product By Range 
//productDetails productData = new productDetails();
//Console.WriteLine("Enter Price Range 1: ");
//int r1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Price Range 2: ");
//int r2 = Convert.ToInt32(Console.ReadLine());
//var data = productData.ConsumeProductsPriceRange(r1, r2);

//foreach (var i in data)
//{

//    Console.WriteLine($"Product ID: {i.pId}");
//    Console.WriteLine($"Product Name: {i.pName}");
//    Console.WriteLine($"Product Price: {i.pPrice}");
//    Console.WriteLine($"Available Quantity: {i.pAvailableQty}");
//    Console.WriteLine($"Description: {i.pDescription}");
//    Console.WriteLine($"Stock Availability Status: {i.pIsInStock}");
//    Console.WriteLine("~~~~~~~~~~");

//}
#endregion

#region 3. Orders where Status is In Progress
//ordersDetails orderData = new ordersDetails();

//var data = orderData.ConsumeOrdersInProgress();
//foreach (var i in data)
//{

//    Console.WriteLine($"Order ID: {i.oId}");
//    Console.WriteLine($"Customer ID: {i.cId}");
//    Console.WriteLine($"Product ID: {i.pId}");
//    Console.WriteLine($"Order Status: {i.oStatus}");

//    Console.WriteLine("~~~~~~~~~~");
//}

#endregion

#region 4. Get Orders By Customer ID
ordersDetails orderData = new ordersDetails();
Console.WriteLine("Enter Customer ID: ");
int cID = Convert.ToInt32(Console.ReadLine());
var data = orderData.ConsumeOrdersCid(cID);

foreach (var i in data)
{

    Console.WriteLine($"Order ID: {i.oId}");
    Console.WriteLine($"Customer ID: {i.cId}");
    Console.WriteLine($"Product ID: {i.pId}");
    Console.WriteLine($"Order Status: {i.oStatus}");

    Console.WriteLine(Environment.NewLine + "~~~~~~~~~~");

}
#endregion




