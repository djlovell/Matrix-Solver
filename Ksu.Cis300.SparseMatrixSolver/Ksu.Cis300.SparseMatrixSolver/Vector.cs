/* Ksu.Cis300.SparseMatrixSolver.cs
 * Author: Daniel J Lovell 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.SparseMatrixSolver
{
    /// <summary>
    /// This Vector class defines a vector that will hold integer indices.
    /// </summary>
    public class Vector
    {
        private LinkedListCell<KeyValuePair<int, double>> _vectors = new LinkedListCell<KeyValuePair<int, double>>();

        public  LinkedListCell<KeyValuePair<int,double>> VectorProperty
        {
            get
            {
                return _vectors;
            }
        }

        public void AddValue(int index, double value)
        {
            KeyValuePair<int, double> k = new KeyValuePair<int, double>(index,value);
            LinkedListCell<KeyValuePair<int, double>> search = _vectors;
            LinkedListCell<KeyValuePair<int, double>> newCell = new LinkedListCell<KeyValuePair<int, double>>();
            newCell.Data = k; //assigns data for your index to a new cell

                while (search.Next != null && search.Next.Data.Key >= index) //iterates while the next index is still larger than your selected index
                {
                    if (search.Next.Data.Key == index) 
                    {
                        throw new InvalidOperationException("Attempt to add a value at an index that already has a value.");
                    }
                    else
                    {
                        search = search.Next; //steps to next place in linked list
                    }
                }
                        newCell.Next = search.Next;
                        search.Next = newCell;
        }//end AddValue

        /// <summary>
        /// This method computes the dot product of two vectors.
        /// </summary>
        /// <param name="v1">This is the first vector passed in.</param>
        /// <param name="v2">this is the second vector passed in.</param>
        /// <returns></returns>
        public static double ComputeDotProduct (LinkedListCell<KeyValuePair<int,double>> v1, LinkedListCell<KeyValuePair<int, double>> v2)
        {
            double sum = 0;
            LinkedListCell<KeyValuePair<int,double>> temp1 = v1;
            LinkedListCell<KeyValuePair<int, double>> temp2 = v2;
            

            while(temp1 != null && temp2 != null) //skipping the 2*-1
            {
                if (temp1.Data.Key == temp2.Data.Key)
                {
                    sum += temp1.Data.Value * temp2.Data.Value;
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;
                }
                else { 
                    if (temp1.Data.Key > temp2.Data.Key)
                    {
                        temp1 = temp1.Next;
                    }
                    else
                    {
                        temp2 = temp2.Next;
                    }
                }
                
               
            }
            return sum;

        }
    }//end class
}
