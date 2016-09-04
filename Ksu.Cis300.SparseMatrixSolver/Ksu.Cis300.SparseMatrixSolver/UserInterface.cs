/* Ksu.Cis300.SparseMatrixSolver.cs
 * Author: Daniel J Lovell 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.SparseMatrixSolver
{
    /// <summary>
    /// This class defines a program that computes the product of two matrices.
    /// </summary>
    public partial class uxMatrixMultiplier : Form
    {
        /// <summary>
        /// Initializes the program window.
        /// </summary>
        public uxMatrixMultiplier()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When this button is clicked, the method that computes the matrix product 
        /// will be called, and the result saved to a new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompute_Click(object sender, EventArgs e)
        {
            try
            {
                ComputeMatrixProduct(ReadMatrix(uxDisplayA.Text, 1, 0), ReadMatrix(uxDisplayB.Text, 0, 1), uxDisplayOutput.Text);
                MessageBox.Show("Matrix written.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// When clicked, this button prompts the user to select 
        /// an input file for the first matrix.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMatrixA_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileA = new OpenFileDialog();
            GetFileName(uxDisplayA, FileA);
        }
        /// <summary>
        /// This button creates a file dialog as well, asking
        /// for the second matrix used in the calculation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMatrixB_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileB = new OpenFileDialog();
            GetFileName(uxDisplayB, FileB);
        }
        /// <summary>
        /// This prompts the user to select an appropriate file
        /// to save the matrix product to (.csv).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog FileOut = new SaveFileDialog();
            GetFileName(uxDisplayOutput, FileOut);
        }

        /// <summary>
        /// This method is what the event handlers call to get a file name from the user. 
        /// The file name is then placed in the respective text box.
        /// </summary>
        /// <param name="t">This is the text box the file name is written to.</param>
        /// <param name="f">This is the File Dialog accessed by the buttons.</param>
        private void GetFileName(TextBox t, FileDialog f)
        {
            f.Filter = "CSV files|*.csv|All files|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                t.Text = f.FileName;
            }
            if(uxDisplayA.Text != "" && uxDisplayB.Text != "" && uxDisplayOutput.Text != "")
            {
                uxCompute.Enabled = true;
            }
        }

        /// <summary>
        /// This method reads in the matrix values from a file.
        /// </summary>
        /// <param name="fileName">Name of the file accessed.</param>
        /// <param name="arrayIndice">This gives the size of the vector array.</param>
        /// <param name="vectorIndice">This determines the indices into the vectors.</param>
        /// <returns></returns>
        private Vector[] ReadMatrix (string fileName, int i1, int i2)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                Vector[] vArray;
                
                string[] s = sr.ReadLine().Split(',');

                if(i1 ==1){
                    vArray = new Vector[Convert.ToInt32(s[0])]; //rows used for array
                }
                else
                {
                    vArray = new Vector[Convert.ToInt32(s[1])]; //columns used for array
                }
                
                for(int i = 0; i < vArray.Length; i++)
                {
                    vArray[i] = new Vector();
                }
                
                while(sr.EndOfStream == false)
                {
                    int j = 0;
                    s = sr.ReadLine().Split(',');
                    if(i1 == 1)
                    {
                        vArray[Convert.ToInt32(s[0])].AddValue(Convert.ToInt32(s[1]), Convert.ToDouble(s[2]));
                    }
                    else
                    {
                        vArray[Convert.ToInt32(s[1])].AddValue(Convert.ToInt32(s[0]), Convert.ToDouble(s[2]));
                    }
                    
                    j++;
                    
                }

                return vArray;
            }
          
        }

        /// <summary>
        /// This method takes in the two vector arrays selected by the user and computes the product.
        /// </summary>
        /// <param name="arr1">First vector array.</param>
        /// <param name="arr2">Second vector array.</param>
        /// <param name="fileOut">Name of the file result will be written to.</param>
        private void ComputeMatrixProduct (Vector[] arr1, Vector[] arr2, string fileOut)
        {
            using (StreamWriter sw = new StreamWriter(fileOut))
            {
                int numberOfRows = arr1.Length;
                int numberOfColumns = arr2.Length;

                sw.WriteLine(numberOfRows.ToString() + ',' + numberOfColumns.ToString());
                

                for(int j = 0; j < numberOfRows; j++)
                {
                    for(int k = 0; k < numberOfColumns; k++)
                    {
                        double dotProduct = Vector.ComputeDotProduct(arr1[j].VectorProperty, arr2[k].VectorProperty);
                        if (dotProduct != 0)
                        {
                            sw.WriteLine(j.ToString()+','+k.ToString()+','+dotProduct.ToString());
                        }
                    }
                }
            }
        }
        private void uxMatrixMultiplier_Load(object sender, EventArgs e)
        {

        }
    }
}
