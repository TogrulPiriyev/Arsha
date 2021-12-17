using Arsha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arsha.ViewModels
{
    public class HomeViewModel
    {
        public List<Client> Clients { get; set; }
        public List<Service> Services { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Category> Categories { get; set; }
        

    }
}
