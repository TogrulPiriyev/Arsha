using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arsha.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string SubTitle { get; set; }
        public string Client { get; set; }
        public int CategoryId { get; set; }
        public DateTime Date { get; set; }
        public string URL { get; set; }
        public Category Category { get; set; }
        public List<PortfolioImage> portfolioImages { get; set; }


    }
}
