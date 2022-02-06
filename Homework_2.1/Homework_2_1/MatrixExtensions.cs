using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_1
{
    public static class MatrixExtensions
    {
        public static Matrix Add(this Matrix firstMatrix, Matrix secondMatrix)
        {
            int newMatrixSize = Math.Max(firstMatrix.Size, secondMatrix.Size);
            int[] newMatrixElements = new int[newMatrixSize];

            for (int i = 0; i < newMatrixSize; i++)

            {

                newMatrixElements[i] = firstMatrix[i, i] + secondMatrix[i, i];  // No out of range exception here, as indexers are safe to get values out of bounds. 

            }



            return new Matrix(newMatrixElements);
        }
    }
}
