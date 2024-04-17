using _001GroupBy;
using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();


//1
//Получить количество заказов для каждого клиента
//Get the number of orders for each customer
// var result = dataContext.Orders.GroupBy(x => x.Customer).Select(x=>new {category = x.Key, orders = x.Count()});
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.category} {r.orders}");
// }

//2
//Получить общую стоимость заказов для каждого клиента
//Get the total cost of orders for each customer

var result1 = dataContext.OrderItems.GroupBy(x => x.Order.Customer.Name).Select(x=>new {Client = x.Key,amount = x.Sum(x=>x.Price)});
foreach (var r in result1)
{
    Console.WriteLine($"{r.Client} {r.amount}");
}

//3
//Получить среднюю стоимость заказов для каждого клиента
//Get the average order value for each customer

// var result2 = dataContext.OrderItems.GroupBy(x => x.Order.Customer)
//     .Select(x => new { client = x.Key, average = x.Average(x => x.Price) });
// foreach (var r in result2)
// {
//     Console.WriteLine($"{r.client},{r.average}");
// }



