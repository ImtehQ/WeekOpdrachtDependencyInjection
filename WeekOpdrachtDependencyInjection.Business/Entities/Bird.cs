using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public abstract class Bird
    {
        internal string sound;
        public string Sound()
        {
            return sound;
        }
    }
}
