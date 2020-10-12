using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class SelectionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public SelectionSort(IEnumerable<T> items) : base (items) { }
        public SelectionSort() { }
        protected override void MakeSort()
        {
            var minindex = 0;

            for(int i = 0; i< Items.Count - 1; i++)
            {
                minindex = i;

                for(int j = i + 1; j < Items.Count; j++)
                {
                    if(Items[j].CompareTo(Items[minindex]) == -1)
                    {
                        minindex = j;
                    }
                }

                if (i != minindex)
                {


                    Swop(i, minindex);
                }
            }
        }
    }
}
