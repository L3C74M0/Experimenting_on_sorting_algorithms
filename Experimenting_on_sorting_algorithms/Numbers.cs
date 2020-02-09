using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_on_sorting_algorithms
{
    public class Numbers: IComparable<Numbers>
    {
        private int n;
        private Numbers left;
        private Numbers right;
        public Numbers(int n)
        {
            this.n = n;
        }

        public int Get()
        {  
            return n;
        }
        public void Set (int nNew){
            n=nNew; 
        }

        public Numbers getLeft()
        {
            return left;
        }


        public void setLeft(Numbers left)
        {
            this.left = left;
        }


        public Numbers getRigth()
        {
            return right;
        }


        public void setRigth(Numbers rigth)
        {
            this.right = rigth;
        }

        public int CompareTo(Numbers n2)
        {
            int comparation;
            if (n < n2.n)
            {
                comparation = -1;
            }
            else if (n > n2.n)
            {
                comparation = 1;
            }
            else
            {
                comparation = 0;
            }
            return comparation;
        }
    }
}