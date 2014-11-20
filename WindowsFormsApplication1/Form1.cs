using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Demo_Click(object sender, EventArgs e)
        {
            int size = 5;

            button_Clear_Click(sender, e);

            InsertColHeaders(size);

            dataGridViewMen.Rows.Add("2", "5", "1", "3", "4");
            dataGridViewMen.Rows.Add("1", "2", "3", "4", "5");
            dataGridViewMen.Rows.Add("2", "3", "5", "4", "1");
            dataGridViewMen.Rows.Add("1", "3", "2", "4", "5");
            dataGridViewMen.Rows.Add("5", "3", "2", "1", "4");

            dataGridViewWomen.Rows.Add("5", "1", "4", "2", "3");
            dataGridViewWomen.Rows.Add("4", "5", "2", "1", "3");
            dataGridViewWomen.Rows.Add("1", "4", "2", "3", "5");
            dataGridViewWomen.Rows.Add("3", "2", "4", "1", "5");
            dataGridViewWomen.Rows.Add("4", "2", "3", "5", "1");

            InsertRowHeaders(size);
        }

        private void button_FindStable_Click(object sender, EventArgs e)
        {
            int[,] menPref = loadPref(dataGridViewMen);
            int[,] womenPref = loadPref(dataGridViewWomen);

            int[] fiancee = stableMatchingAlgo(menPref, womenPref);

            //show results            
            textBox_Output.AppendText("\r\n Solution to stable matiching problem: \r\n");
            for (int i = 0; i < fiancee.Length; i++)
                textBox_Output.AppendText("W" + (i+1) + "-M" + (fiancee[i]+1) + "; ");
        }

        //Stable Matching Algorithm
        public int[] stableMatchingAlgo(int[,] manPref, int[,] womenPref)
        {
            int size = manPref.GetLength(1);

            int[,] rank = getRankedMatrixWithDummy(womenPref);

            //start stable marriage algorithm
            int[] fiancee = new int[size];
            int[] next = new int[size];  //to track the next in the list of candidates

            for (int i = 0; i < size; i++)  //initialize counters
            {
                fiancee[i] = i;
                next[i] = -1;
            }

            for (int m = 0; m < size; m++)
            {
                int s = m;

                while (s != size)
                {
                    next[s] = next[s] + 1;
                    int w = manPref[s, next[s]];

                    if (rank[w, s] < rank[w, fiancee[w]])
                    {
                        int t = fiancee[w];
                        fiancee[w] = s;
                        s = t;
                    }
                }
            }

            return fiancee;
        }

        private int[,] loadPref(DataGridView dgv)
        {
            int size = dgv.Columns.Count;

            int[,] pref = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    pref[i, j] = Convert.ToInt32(dgv.Rows[i].Cells[j].Value)-1; //-1 to keep values in range (0,n-1)

            return pref;
        }

        /** Converts from a preference matrix to a ranked-preference matrix, i.e. 
         * converts from vector elements showing preferences sorted by column
         * to vector elements were each element shows their particular order in the array 
         * Example: Pref=[5,1,4,2,3] -> RankedPref=[2,4,5,3,1]
         * (Pref) first element shows that first prefered is 5, second prefered is 1.
         * (RankedPref) first element shows that first element is second in order, 
         * second element is fourth in order, and so on, last element is the first in order.
         */
        public int[,] getRankedMatrixWithDummy(int[,] preferenceMatrix)
        {
            int size = preferenceMatrix.GetLength(1);

            //add extra column to rank for initialization with a dummy
            int[,] rank = new int[size, size + 1];

            //convert from a preference matrix to a ranked-preference matrix
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    rank[i, preferenceMatrix[i, j]] = j;

            //initialize dummy column with largest possible value
            for (int i = 0; i < size; i++)
                rank[i, size] = size;

            return rank;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dataGridViewMen.Rows.Clear();
            dataGridViewWomen.Rows.Clear();
            dataGridViewMen.Columns.Clear();
            dataGridViewWomen.Columns.Clear();
        }

        private void InsertRowHeaders(int size)
        {
            for (int i = 0; i < size; i++)
            {
                dataGridViewMen.Rows[i].HeaderCell.Value = "M" + (i+1);
                dataGridViewWomen.Rows[i].HeaderCell.Value = "W" + (i+1);
            }

            dataGridViewMen.RowHeadersWidth = 73;
            dataGridViewWomen.RowHeadersWidth = 73;
        }

        private void InsertColHeaders(int size)
        {
            for (int i = 0; i < size; i++)
            {
                dataGridViewMen.Columns.Add("colM" + i, (i+1).ToString());
                dataGridViewWomen.Columns.Add("colW" + i, (i+1).ToString());
            }
        }

    }
}
