using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_1
{
    public class Matrix
    {
        public int[] Diagonal { get; private set; }
        public int Size { get; private set; }

        public int this[int i, int j]
        {
            get
            {
                if (i != j)
                {
                    return 0;
                }
                else if (i < 0 || i >= Size || j < 0 || j >= Size)
                {
                    return 0;
                }


                return Diagonal[i];
            }

            set
            {
                if (i != j)
                {
                    return;
                }
                else if (i < 0 || i >= Size || j < 0 || j >= Size)
                {
                    return;
                }


                Diagonal[i] = value;
            }
        }

        public Matrix(params int[] members)
        {
            Diagonal = members ?? Array.Empty<int>();
            Size = Diagonal.Length;
        }

        public int Track() => Diagonal.Sum();

        public override bool Equals(object? obj)
        {
            if (obj is null or not Matrix)
            {
                return false;
            }

            var matrixToCompare = (Matrix)obj;

            if (Size != matrixToCompare.Size)
            {
                return false;
            }

            return Diagonal.SequenceEqual(matrixToCompare.Diagonal);
        }

        public override string ToString()
        {
            return "Matrix class ToString is overriden!";
        }
    }
}
