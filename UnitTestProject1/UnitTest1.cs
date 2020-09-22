using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMatrix;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*Проверка сложения матриц одной размерности*/
        [TestMethod]
        public void Test_Add_Normal_Matrix()
        {
            Matrix a = new Matrix(new int[,]
            {
                {2, 1},
                {3, 4}
            }
            );
            Matrix b = new Matrix(new int[,]
            {
                {2, 3},
                {1, 2}
            });


            Matrix expected = new Matrix(new int[,]
            {
                {4, 4},
                {4, 6}
            });

            Matrix actual = Matrix.Add(a, b);


            Assert.AreEqual(expected, actual);
        }

        /*Проверка сложения матриц разной размерности, ожидается ошибка*/
        [TestMethod]
        public void Test_Add_Matrix_With_Different_Size_Exception_Expected()
        {
            Matrix a = new Matrix(new int[,]
            {
                {2, 1},
                {3, 4}
            }
            );
            Matrix b = new Matrix(new int[,]
            {
                {2, 3},
                {1, 2},
                { 1, 6}
            });



            Assert.ThrowsException<ArithmeticException>(() => Matrix.Add(a, b));
        }

        /*Проверка умножения матриц допустимой размерности*/

        [TestMethod]
        public void Test_Multiply_Normal_Matrix()
        {
            Matrix a = new Matrix(new int[,]
            {
                {2, 1},
                {3, 4},
                {3, 4}
            }
            );
            Matrix b = new Matrix(new int[,]
            {
                {2, 3, 2},
                {1, 2, 3}
            });


            Matrix expected = new Matrix(new int[,]
            {
                {5,  8,   7},
                {10,  17,  18},
                {10,  17,  18},
            });

            Matrix actual = Matrix.Multiply(a, b);


            Assert.AreEqual(expected, actual);
        }

        /*Проверка умножения матриц разной размерности, ожидается ошибка*/
        [TestMethod]
        public void Test_Multiply_Matrix_With_Different_Size_Exception_Expected()
        {
            Matrix a = new Matrix(new int[,]
            {
                {2, 1},
                {3, 4}
            }
            );
            Matrix b = new Matrix(new int[,]
            {
                {2, 3},
                {1, 2},
                {1, 6}
            });



            Assert.ThrowsException<ArithmeticException>(() => Matrix.Multiply(a, b));
        }

        /*Проверка вычисления определителя квадратной матрицы*/
        [TestMethod]
        public void Test_Det_Normal()
        {
            Matrix a = new Matrix(new int[,]
           {
                {2, 3, 4},
                {1, 2, 1},
                {1, 6, 2}
           });
            int expected = 9;
           
            int actual = Matrix.Det(a);


            Assert.AreEqual(expected, actual);
        }

        /*Проверка вычисления определителя неквадратной матрицы, ожидается ошибка*/
        [TestMethod]
        public void Test_Det_Non_Square_Matrix()
        {
            Matrix a = new Matrix(new int[,]
            {
                {2, 1, 3},
                {3, 4, 1}
            }
            );
           

           Assert.ThrowsException<ArithmeticException>(() => Matrix.Det(a));
        }
        /*Проверка умножения матрицы на число*/
        [TestMethod]
        public void Test_Multiply_Normal_Matrix_Number()
        {
            Matrix a = new Matrix(new int[,]
            {
                {2, 3},
                {1, 2},
                {1, 6}
            });
            int coef = -2;

            Matrix expected = new Matrix(new int[,]
            {
                {-4, -6},
                {-2, -4},
                {-2, -12}
            });

            Matrix actual = Matrix.Multiply(a, coef);

            Assert.AreEqual(expected, actual);
        }
    }
}


