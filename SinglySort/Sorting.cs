using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglySort
{
    interface ISort
    {
        int Perest { get; set; }
        int Sravn { get; set; }
    }

    abstract class sortAbstract<T>
    {
        public abstract List<T> Sorting(List<T> unsorted);
        public T temp;
    }

    class UnsortedList<T>
    {
        public List<T> Input { get; private set; }

        public UnsortedList(List<T> data)
        {
            Input = data;
        }
    }

    class QSort<T> : sortAbstract<T>, ISort
    {
        public int Perest { get; set; }
        public int Sravn { get; set; }

        //метод возвращающий индекс опорного элемента
        int Partition(List<T> array, int minIndex, int maxIndex)

        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i, ' '] < array[maxIndex, ' '])
                {
                    pivot++;

                    temp = array[pivot];
                    array[pivot] = array[i];
                    array[i] = temp;

                    Perest++;
                }
                Sravn++;
            }

            pivot++;

            temp = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = temp;
            
            Perest++;
            return pivot;
        }

        List<T> QuickSort(List<T> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return array;

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public List<T> QuickSort(List<T> array)
        {
            return QuickSort(array, 0, array.Count - 1);
        }

        public override List<T> Sorting(List<T> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                Sravn++;
                return unsorted;
            }

            List<T> list = QuickSort(unsorted, 0, unsorted.Count - 1);

            return list;
        }
    }

    class BSort<T> : sortAbstract<T>, ISort
    {
        public int Perest { get; set; }
        public int Sravn { get; set; }

        public override List<T> Sorting(List<T> unsorted)
        {
            return BubSort(unsorted);
        }

        public List<T> BubSort(List<T> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = 0; j < array.Count - i - 1; j++)
                {
                    if (array[j + 1, ' '] < array[j, ' '])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        Perest++;
                    }
                    Sravn++;
                }
            }
            return array;
        }
    }
}
