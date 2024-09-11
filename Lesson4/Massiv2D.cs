using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Massiv2D
    {
        private int[,] mas;
        public int Rows { get; set; }
        public int Cols { get; set; }
        private bool errFlag;
        private int lenght;
        public Massiv2D(int rows,int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            errFlag = false;
            lenght = this.Rows * this.Cols;
            mas = new int[rows, cols];
        }
        public int this[int index1,int index2]
        {
            get
            {
                if(Ok(index1,index2))
                {
                    errFlag = false;
                    return mas[index1, index2];
                }
                else
                {
                    errFlag = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index1, index2))
                {
                    mas[index1, index2] = value;
                    errFlag = false;
                }
                errFlag = true;
            }
        }
        public void Fill()
        {
            Random random = new Random();
            for(int i=0;i<Rows;i++)
            {
                for (int j = 0; j < Cols; j++)
                    mas[i, j] = random.Next(10, 100);
            }
        }

        private bool Ok(int index1, int index2)
        {
            if (index1 >= 0 && index1 < Rows &&
            index2 >= 0 && index2 < Cols)
                return true;
            return false;
        }
        public int Different()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (!list.Contains(mas[i,j]))
                    {
                        list.Add(mas[i, j]);
                    }
                }
            }
            return list.Count;
        }
    }
}
