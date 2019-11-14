using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {

        public int[,] myMatrix;

        public int mcountofrow;

        public int countofrow
        {
            get { return mcountofrow; }

        }


        public int mcountofcolum;

        public int countofcolum
        {
            get { return mcountofcolum; }
            set { mcountofcolum = countofcolum; }
        }

        public Matrix()
        { }

        public Matrix(int numberofrows, int numberofcolums)
        {
            mcountofrow = numberofrows;
            mcountofcolum = numberofcolums;
            myMatrix = new int[numberofrows, numberofcolums];

        }

        public void setrows(int[] values, int rowindex)
        {
            if (values.Length != mcountofcolum)
                throw new Exception("valid values");

            for (int i = 0; i < values.Length; i++)
            {
                myMatrix[rowindex, i] = values[i];
            }

        }


        public void setcolums(int[] values, int columnindex)
        {
            if (values.Length != mcountofrow)
                throw new Exception("valid values");

            for (int i = 0; i < values.Length; i++)
                myMatrix[i, columnindex] = values[i];

        }

        public void printmatrix()
        {
            for (int i = 0; i < mcountofrow; i++)
            {
                for (int j = 0; j < mcountofcolum; j++)
                    Console.Write($"   { myMatrix[i, j]}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        public int this[int rowNumber, int columnNumber]
        {
            get
            {
                return myMatrix[rowNumber, columnNumber];
            }
            set
            {
                myMatrix[rowNumber, columnNumber] = value;
            }
        }

       
        
        public static Matrix addition  (Matrix firstmatrix, Matrix secondmatrix)
        {
            if (!(firstmatrix.mcountofrow == secondmatrix.mcountofrow && firstmatrix.mcountofcolum == secondmatrix.mcountofcolum))
                throw new Exception(" valid values");

            Matrix result = new Matrix(firstmatrix.mcountofrow,firstmatrix.mcountofcolum);
            for (int i = 0; i < firstmatrix.mcountofrow; i++)
                for (int j = 0; j < firstmatrix.mcountofcolum; j++)
                    result[i, j] = firstmatrix[i, j] + secondmatrix[i, j];
            return result;
        }
        


        public static  Matrix multiplication(Matrix matrix1, Matrix matrix2)
        {
            if (!(matrix1.mcountofrow == matrix2.mcountofrow && matrix2.mcountofcolum == matrix2.mcountofcolum))
                throw new Exception("valid values");

            Matrix result = new Matrix(matrix2.mcountofrow,matrix2.mcountofcolum);
            for (int i = 0; i < matrix1.mcountofrow; i++)
                for (int j = 0; j < matrix1.mcountofcolum; j++)
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
            return result;

        }

        public (int, int) max_min()
        {
            int min = this[0, 0];
            int max = 0;
            for (int i = 0; i < this.mcountofrow; i++)
                for (int j = 0; j < this.countofcolum; j++)
                    if (max < this[i, j])
                        max = this[i, j];
            for (int i = 0; i < this.mcountofrow; i++)
                for (int j = 0; j < this.countofcolum; j++)
                    if (this[i, j] < min)
                        min = this[i, j];
            return (max, min);
        }


        public Matrix matrix_transpon()
        {
            Matrix transponmatrix = new Matrix(this.mcountofcolum, this.mcountofrow);
            for (int i = 0; i < transponmatrix.countofrow; i++)
                for (int j = 0; j < transponmatrix.countofcolum; j++)
                    transponmatrix[i, j] = this[j, i];
            return transponmatrix;

        }





    }
}
