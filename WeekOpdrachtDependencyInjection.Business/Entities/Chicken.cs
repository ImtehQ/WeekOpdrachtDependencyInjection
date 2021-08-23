using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class Chicken : Bird
    {
        public Chicken()
        {
            sound = "cluck";
        }
    }
}
