using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCore.Entities
{
    public class TransmissionType:GenericType
    {
        public List<Car> Cars { set; get; }
    }
}
