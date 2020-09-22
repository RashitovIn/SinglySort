using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SinglySort
{
    class Components
    {
        public void OutPut<T>(ListBox LB, List<T> list)
        {
            LB.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                LB.Items.Add(Convert.ToString(list[i]));
            }
        }

        public List<double> GetRDL(int Size, Random rand)   //Get random double list
        {
            List<double> list = new List<double>();

            for (int i = 0; i < Size; i++)
            {
                list.Add(rand.NextDouble() * rand.Next(10, 1000));
            }

            return list;
        }

        public List<int> GetRIL(int Size, Random rand)   //Get random int list
        {
            List<int> list = new List<int>();

            for (int i = 0; i < Size; i++)
            {
                list.Add(rand.Next(-1000, 10000));
            }

            return list;
        }

        public List<string> GetRSL(int Size, Random rand)   //Get random string list
        {
            List<string> list = new List<string>();
            string tstr = "";

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < rand.Next(3, 10); j++)
                {
                    tstr += (char)rand.Next(65, 122);
                }
                list.Add(tstr);
                tstr = "";
            }

            return list;
        }

        public static List<T> Copy<T>(List<T> vec)
        {
            List<T> vec1 = new List<T>();
            for (int i = 0; i < vec.Count; i++)
                vec1.Add(vec[i]);
            return vec1;
        }

        public void Sort<T>(UnsortedList<T> UnArr, Label cComB, Label cTrB, Label cComQ, Label cTrQ, ListBox BSortLB, ListBox QSortLB, Label timeLabB, Label timeLabQ)
        {
            Components Comp = new Components();

            BSort<T> bSort = new BSort<T>();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<T> listB = bSort.Sorting(Copy(UnArr.Input));

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            timeLabB.Text = string.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            cComB.Text = Convert.ToString(bSort.Sravn);
            cTrB.Text = Convert.ToString(bSort.Perest);

            Comp.OutPut(BSortLB, listB);

            //--------------------------------------

            QSort<T> qSort = new QSort<T>();

            Stopwatch stopWatchQ = new Stopwatch();
            stopWatchQ.Start();

            List<T> listQ = qSort.Sorting(Copy(UnArr.Input));

            stopWatchQ.Stop();
            TimeSpan tsQ = stopWatchQ.Elapsed;
            timeLabQ.Text = string.Format("{0:00}:{1:00}.{2:00}", tsQ.Minutes, tsQ.Seconds, tsQ.Milliseconds / 10);
            cComQ.Text = Convert.ToString(qSort.Sravn);
            cTrQ.Text = Convert.ToString(qSort.Perest);

            Comp.OutPut(QSortLB, listQ);
        }
    }
}
