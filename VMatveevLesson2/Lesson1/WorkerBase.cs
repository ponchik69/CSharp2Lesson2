using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatveevLesson2
{
   public abstract class WorkerBase
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        protected double _MonthCost;

        public virtual double GetCost()
        {
            return _MonthCost;
        }
        public abstract void SetCost(double Cost);

    }
}
