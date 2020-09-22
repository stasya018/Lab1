using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    class Program
    {
        static void Main()
        { }

    }

    public class Matrix
    {
        int Columns;
        int Rows;

        int[,] arr;


        public Matrix(int[,] arr)
        {
            throw new NotImplementedException();
        }


        public static Matrix Add(Matrix left, Matrix right)
        {
            throw new NotImplementedException();
        }

        public static Matrix Multiply(Matrix left, Matrix right)
        {
            throw new NotImplementedException();
        }

        public static Matrix Multiply(Matrix left, int right)
        {
            throw new NotImplementedException();
        }
        public static Matrix Tran(Matrix a)
        {
            throw new NotImplementedException();
        }

        public static int Det(Matrix a)
        {
            throw new NotImplementedException();
        }
    }
}
