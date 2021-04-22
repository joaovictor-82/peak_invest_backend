using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PeakInvest.API.Models;

namespace PeakInvest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        const byte percentage = 5;

        [HttpPost]
        public double Calculate(Installment model)
        {
            double total = (model.TotalValue * model.Installments);
            total += total * (percentage / 100d);
            return total;
        }

        [HttpGet("{id}")]
        public KeyValuePair<int, string> GetCustomer(int id)
        {
            var list = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "João"),
                new KeyValuePair<int, string>(2, "Maria"),
                new KeyValuePair<int, string>(3, "Ana")
            };

            return list.FirstOrDefault(x => x.Key == id);
        }
    }
}
