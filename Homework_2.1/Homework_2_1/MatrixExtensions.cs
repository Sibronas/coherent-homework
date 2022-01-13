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
            var diagonal = new List<int>();

            if (firstMatrix.Size == secondMatrix.Size)
            {
                for (var i = 0; i < firstMatrix.Size; i++)
                {
                    diagonal.Add(firstMatrix[i, i] + secondMatrix[i, i]);
                }

                return new Matrix(diagonal.ToArray());
            }
            else if (firstMatrix.Size > secondMatrix.Size)
            {
                var secondMatrixWithPadding = new List<int>();

                for (var i = 0; i < firstMatrix.Size; i++)
                {
                    if (i > secondMatrix.Size)
                    {
                        secondMatrixWithPadding.Add(0);
                    }

                    secondMatrixWithPadding.Add(secondMatrix[i, i]);
                }

                for (var i = 0; i < firstMatrix.Size; i++)
                {
                    diagonal.Add(firstMatrix[i, i] + secondMatrixWithPadding[i]);
                }
            }
            else
            {
                var firstMatrixWithPadding = new List<int>();

                for (var i = 0; i < secondMatrix.Size; i++)
                {
                    if (i > firstMatrix.Size)
                    {
                        firstMatrixWithPadding.Add(0);
                    }

                    firstMatrixWithPadding.Add(firstMatrix[i, i]);
                }

                for (var i = 0; i < secondMatrix.Size; i++)
                {
                    diagonal.Add(firstMatrixWithPadding[i] + secondMatrix[i, i]);
                }
            }

            return new Matrix(diagonal.ToArray());
        }
    }
}
