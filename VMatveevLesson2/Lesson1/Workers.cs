using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatveevLesson2
{

    public class WorkerAtMonth : WorkerBase, IComparable
    {
        public WorkerAtMonth(string firstTime, string lastName)
        {
            FirstName = firstTime;
            LastName = lastName;
        }

        //public override double GetCost()
        //{
        //    return _MonthCost;
        //}

        public override void SetCost(double Cost)
        {
            _MonthCost = Cost;
        }

        public int CompareTo(object worker)
        {
            WorkerAtMonth tmp = (WorkerAtMonth)worker;
            return this._MonthCost.CompareTo(tmp._MonthCost);
        }
    }

    public class WorkerAtHour : WorkerBase, IComparable
    {
        public double Сoefficient { get; set; } = 20.8;
        public int WorkHour { get; set; } = 8;

        public WorkerAtHour(string firstTime, string lastName)
        {
            FirstName = firstTime;
            LastName = lastName;
        }

        //public override double GetCost()
        //{
        //    return _MonthCost;
        //}

        public override void SetCost(double Cost)
        {
            _MonthCost = Сoefficient * WorkHour + Cost;
        }

        public int CompareTo(object worker)
        {
            WorkerAtHour tmp = (WorkerAtHour)worker;
            return this._MonthCost.CompareTo(tmp._MonthCost);
        }
    }

    public class Workers: IEnumerable, IEnumerator
    {
        WorkerBase[] _Workers = new WorkerBase[20];
        int index = -1;

        public Workers()
        {
            for (int i = 0; i < 20; i++)
            {
                WorkerAtHour tmp = new WorkerAtHour("sd", "asda");
                _Workers[i] = tmp;
            }
        }

        public int Length
        {
            get { return _Workers.Length; }
        }

        public WorkerBase this[int index]
        {
            get
            {
                return _Workers[index];
            }
            set
            {
                _Workers[index] = value;
            }
        }

        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        #endregion IEnumerable

        #region IEnumerator
        public bool MoveNext()
        {
            if (index == _Workers.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return _Workers[index];
            }
        }
        #endregion IEnumerator
    }
}
