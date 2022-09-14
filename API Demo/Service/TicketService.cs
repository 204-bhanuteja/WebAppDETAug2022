using API_Demo.Model;

namespace API_Demo.Service
{
    public class TicketService
    {
       
            static List<Ticket> Tickets { get; }
      
            static TicketService()
            {
                Tickets = new List<Ticket>
                {
                    new Ticket {Id =1, BookedFor="PlatinumPlus",Price= 5000, Qty=20},
                new Ticket { Id =11, BookedFor="Platinum",Price= 4000, Qty=30},
                new Ticket  { Id =13, BookedFor= "Gold",Price= 3000, Qty=50},
                new Ticket   {Id =15, BookedFor="Silver",Price= 2000, Qty=5},
                new Ticket   {Id =17, BookedFor="General",Price= 800, Qty=10},
                };
            }

            public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket= Tickets.FirstOrDefault(x=>x.Id==id);
            return ticket;
        }
        }
}
