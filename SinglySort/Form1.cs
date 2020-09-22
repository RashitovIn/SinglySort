using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SinglySort
{
    public partial class Form1 : Form
    {
        Components Comp = new Components();

        public Form1()
        {
            InitializeComponent();
            sizeInp.Text = "15";
        }

        private void IntInp_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int size = Convert.ToInt32(sizeInp.Text);

            List<int> List = Comp.GetRIL(size, rand);
            UnsortedList<int> input = new UnsortedList<int>(List);

            Comp.OutPut(GenLB, List);
            Comp.Sort(input, cComB, cTrB, cComQ, cTrQ, BSortLB, QSortLB, timeLabB, timeLabQ);
        }

        private void DoubleInp_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int size = Convert.ToInt32(sizeInp.Text);

            List<double> List = Comp.GetRDL(size, rand);
            UnsortedList<double> input = new UnsortedList<double>(List);

            Comp.OutPut(GenLB, List);
            Comp.Sort(input, cComB, cTrB, cComQ, cTrQ, BSortLB, QSortLB, timeLabB, timeLabQ);
        }

        private void StrInp_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int size = Convert.ToInt32(sizeInp.Text);

            List<string> List = Comp.GetRSL(size, rand);
            UnsortedList<string> input = new UnsortedList<string>(List);

            Comp.OutPut(GenLB, List);
            Comp.Sort(input, cComB, cTrB, cComQ, cTrQ, BSortLB, QSortLB, timeLabB, timeLabQ);
        }

        private void ClearInp_Click(object sender, EventArgs e)
        {
            manInp.Text = "";
            GenLB.Items.Clear();
            BSortLB.Items.Clear();
            QSortLB.Items.Clear();
            timeLabB.Text = "-";
            timeLabQ.Text = "-";
            cTrB.Text = "-";
            cTrQ.Text = "-";
            cComB.Text = "-";
            cComQ.Text = "-";
        }

        private void ManSortInt_Click(object sender, EventArgs e)
        {
            string[] s = manInp.Text.Split('\r');
            List<int> list = new List<int>();

            for (int i = 0; i < s.Length; i++)
                list.Add(int.Parse(s[i]));

            UnsortedList<int> input = new UnsortedList<int>(list);
            Comp.OutPut(GenLB, list);
            Comp.Sort(input, cComB, cTrB, cComQ, cTrQ, BSortLB, QSortLB, timeLabB, timeLabQ);
        }

        private void ManSortDouble_Click(object sender, EventArgs e)
        {
            string[] s = manInp.Text.Split('\r');
            List<double> list = new List<double>();

            for (int i = 0; i < s.Length; i++)
                list.Add(double.Parse(s[i]));

            UnsortedList<double> input = new UnsortedList<double>(list);
            Comp.OutPut(GenLB, list);
            Comp.Sort(input, cComB, cTrB, cComQ, cTrQ, BSortLB, QSortLB, timeLabB, timeLabQ);
        }

        private void ManSortString_Click(object sender, EventArgs e)
        {
            string[] s = manInp.Text.Split('\r');
            List<string> list = new List<string>();

            for (int i = 0; i < s.Length; i++)
                list.Add(s[i]);

            UnsortedList<string> input = new UnsortedList<string>(list);
            Comp.OutPut(GenLB, list);
            Comp.Sort(input, cComB, cTrB, cComQ, cTrQ, BSortLB, QSortLB, timeLabB, timeLabQ);
        }
    }
}
