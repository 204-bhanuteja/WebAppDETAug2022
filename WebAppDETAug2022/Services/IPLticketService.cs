using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{ }
//public class IPLticketService
//{
//    static List<IPLticket> Tickets { get; }
//    static int nextId = 3;
//    static IPLticketService()
//    {
//        Tickets = new List<IPLticket>
//                {
//                    new IPLticket {Id = "PlatinumPlus",Price= 5000, MaxLimit=200000},
//                new IPLticket { Id = "Platinum",Price= 4000, MaxLimit=300000},
//                new IPLticket { Id = "Gold",Price= 3000, MaxLimit=500000},
//                new IPLticket  {Id = "Silver",Price= 2000, MaxLimit=50000},
//                new IPLticket  {Id = "General",Price= 800, MaxLimit=10000},
//                };
//    }

//    public static List<IPLticket> GetAll() => Tickets;

//    public static IPLticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

//    public static void Add(IPLticket pizza)
//    {
//        IPLticket.Id = nextId++;
//        Tickets.Add(pizza);
//    }

//    public static void Delete(int id)
//    {
//        var IPLticket = Get(id);
//        if (pizza is null)
//            return;

//        Pizzas.Remove(pizza);
//    }

//    public static void Update(Pizza pizza)
//    {
//        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
//        if (index == -1)
//            return;

//        Pizzas[index] = pizza;
//    }
//}
//}
