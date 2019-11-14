using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 4);
            Matrix matrix2 = new Matrix(3, 4);

            matrix1.printmatrix();

            int [] a = { 1,2,3,4};
            matrix1.setrows(a,0);

            matrix1.printmatrix();

            int[] b = { 6, 7, 8,9 };
            int[] c = { -11, 25, -8, 74 };
            matrix2.setrows(b, 0);
            matrix2.setrows(c, 1);
            matrix2.printmatrix();

          Matrix  resultmatrix = Matrix.addition(matrix1, matrix2);
            resultmatrix.printmatrix();

            resultmatrix = Matrix.multiplication(matrix1, matrix2);

            resultmatrix.printmatrix();

            int max, min;
            var (max1, min1) = matrix2.max_min();

            Console.WriteLine($"The maximum value of matrix 2 is {max1} and the minimum value of the matrix2 is {min1}");

            Matrix matrix3 = matrix2.matrix_transpon();

            matrix3.printmatrix();
            Console.ReadLine();

        }
    }
}
