using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoFlow
{
public class TableModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string TableNumber { get; set; }
        public int Seats { get; set; }
        public string Status { get; set; } = "Available";

        public string Time { get; set; } = "";
        public string GuestName { get; set; } = "";
    }
}
