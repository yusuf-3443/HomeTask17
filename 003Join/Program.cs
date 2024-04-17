using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();

Console.WriteLine("Good look  😊😊😊");

//1
//Получите все заказы с указанием имени клиента и количества заказа клиента.
//Get all orders with customer name and customer order quantity

// var res = from or in dataContext.OrderItems
//     join o in dataContext.Orders on or.OrderId equals o.Id
//     join c in dataContext.Customers on o.CustomerId equals c.Id
//     select new { Name = c.Name, Orders = or.ProductName, Count = or.ProductName.Count() };
// foreach (var r in res)
// {
//     Console.WriteLine($"{r.Name},{r.Orders},{r.Count}");
// }

//2
//Получить все заказы с именем клиента и стоимостью заказа
//Get all orders with customer name and order value
// var res1 = from or in dataContext.OrderItems
//     join o in dataContext.Orders on or.OrderId equals o.Id
//     join c in dataContext.Customers on o.CustomerId equals c.Id
//     select new { Order = or.ProductName, Customer = c.Name };
// foreach (var r in res1)
// {
//     Console.WriteLine($"{r.Order},{r.Customer}");
// }

//3
//Получите все заказы с указанием имени клиента и количества продукции
//Get all orders with customer name and product quantity:
var res2 = from or in dataContext.OrderItems
join o in dataContext.Orders on or.OrderId equals o.Id
join c in dataContext.Customers on o.CustomerId equals c.Id
    select new { Order = or.ProductName, Customer = c.Name, Count = or.ProductName.Count()};
foreach (var r in res2)
{
    Console.WriteLine($"{r.Order},{r.Customer},{r.Count}");
}



