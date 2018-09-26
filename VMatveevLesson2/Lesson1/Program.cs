using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatveevLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerBase[] _Workers = new WorkerBase[10];

            for (int i = 0; i < _Workers.Count(); i++)
            {
                WorkerAtHour tmp = new WorkerAtHour("as", "qqd");
                tmp.SetCost(0.2 * i);
                _Workers[i] = tmp;
            }

            Array.Sort(_Workers);

            for (int i = 0; i < _Workers.Count(); i++)
            {
                Console.WriteLine("{0} {1} {2}", _Workers[i].LastName, _Workers[i].LastName, _Workers[i].GetCost());
            }

            for (int i = 0; i < _Workers.Count(); i++)
            {
                WorkerAtMonth tmp = new WorkerAtMonth("assd", "qasdqd");
                tmp.SetCost(5000 * i);
                _Workers[i] = tmp;
            }

            Array.Sort(_Workers);

            for (int i = 0; i < _Workers.Count(); i++)
            {
                Console.WriteLine("{0} {1} {2}", _Workers[i].LastName, _Workers[i].LastName, _Workers[i].GetCost());
            }


            Workers wrk = new Workers();

            foreach (WorkerAtHour men in wrk)
                Console.WriteLine("{0} {1} {2}",men.FirstName, men.LastName, men.GetCost());


            Console.ReadKey();
        }
    }
}
