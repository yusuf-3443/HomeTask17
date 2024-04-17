using System.Security.Cryptography;
using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();



//1
//Получить все заказы, сделанные клиентом с именем "Ahmad", а также все заказы, в которых был заказан товар с названием "Water"
//Retrieve all orders placed by a customer named "Ahmad" as well as all orders that included a product named "Water"

// var result2 = dataContext.OrderItems.Where(x=>x.Order.Customer.Name.Contains("Ahmad")).Where(x=>x.ProductName.Contains("Water"));
//
// foreach (var r2 in result2)
// {
//     Console.WriteLine($"{r2.Order?.Customer?.Name},{r2.ProductName}");
// }

//2
//Получить все заказы, сделанные клиентом с именем "Akmal", а также все заказы, в которых был заказан товар с названием "Banana"
//Retrieve all orders placed by a customer named "Akmal" as well as all orders that included a product named "Banana"

var result = dataContext.OrderItems.Where(x => x.Order.Customer.Name.Contains("Akmal"))
    .Where(x => x.ProductName.Contains("Banana"));
foreach (var r in result)
{
    Console.WriteLine($"{r.Order?.Customer?.Name}, {r.ProductName}");
}

dataContext.Database.EnsureDeleted();