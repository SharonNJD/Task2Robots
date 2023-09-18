using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker :Worker
    {
        private double Hourlywage;
        private int Hours;

        public OperationalWorker(string name, string id, DateTime bDate, string pass, double Hourlywage, int Hours)
            : base(name, id, bDate, pass)
        {
            this.Hourlywage = Hourlywage;
            this.Hours = Hours;
        }

        public override double Salary()
        {
            
            return Hours * (Hourlywage);
        }

    }
}
