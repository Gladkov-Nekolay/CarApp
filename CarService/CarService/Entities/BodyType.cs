using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarCore.Entities
{
    public class BodyType : GenericType
    {
        public List<Car> Cars { set; get; }
    }
}
