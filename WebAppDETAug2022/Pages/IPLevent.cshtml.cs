using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLeventModel : PageModel
    {
        public List<IPLticket> Tickets { get; set; }
        public void OnGet()
        {
             Tickets = new List<IPLticket> { 
            
                new IPLticket {Category = "PlatinumPlus",Price= 5000, MaxLimit=200000},
                new IPLticket {Category = "Platinum",Price= 4000, MaxLimit=300000},
                new IPLticket {Category = "Gold",Price= 3000, MaxLimit=500000},
                new IPLticket {Category = "Silver",Price= 2000, MaxLimit=50000},
                new IPLticket {Category = "General",Price= 800, MaxLimit=10000},
            };
            }
    }
}
            
            
            
            
            
        
    

