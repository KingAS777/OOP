using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    abstract class Array
    {
        public abstract Array Add(Array other);
        public abstract void ForEach(Action<int> action);
    }

    class SortArray : Array
    {
        private List<int> values;

        public SortArray(IEnumerable<int> values)
        {
            this.values = new List<int>(values);
        }

        public override Array Add(Array other)
        {
            if (other is SortArray sortArray)
            {
                var combined = new List<int>(this.values);
                combined.AddRange(sortArray.values);
                return new SortArray(combined);
            }

            return null;
        }

        public override void ForEach(Action<int> action)
        {
            this.values.Sort();
            foreach (var value in this.values)
            {
                action(value);
            }
        }
    }

    class XorArray : Array
    {
        private List<int> values;

        public XorArray(IEnumerable<int> values)
        {
            this.values = new List<int>(values);
        }

        public override Array Add(Array other)
        {
            if (other is XorArray xorArray)
            {
                var combined = new List<int>(this.values);
                foreach (var value in xorArray.values)
                {
                    if (!combined.Contains(value))
                    {
                        combined.Add(value);
                    }
                    else
                    {
                        combined.Remove(value);
                    }
                }
                return new XorArray(combined);
            }

            return null;
        }

        public override void ForEach(Action<int> action)
        {
            foreach (var value in this.values)
            {
                action((int)Math.Sqrt(value));
            }
        }
    }
}
