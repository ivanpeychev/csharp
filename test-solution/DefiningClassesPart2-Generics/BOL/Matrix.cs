using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matrix<T>
{
    private T[,] item;
    public int Rows { get; private set; }
    public int Columns { get; private set; }
    public Matrix()
    {
        this.Rows = 5;
        this.Columns = 5;
        this.item = new T[Rows, Columns];
    }
    public Matrix(int a, int b)
    {
        this.Rows = a;
        this.Columns = b;
        this.item = new T[Rows, Columns];
    }

    public T this[int row, int col]
    {
        get
        {
            return this.item[row, col];
        }
        set
        {
            this.item[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
        {
            throw new Exception("Matrices with different width or height.");
        }

        var resultArray = new Matrix<T>(a.Rows, a.Columns);
        if (typeof(int) == typeof(T))
        {
            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Columns; col++)
                {
                    T test = a[row, col];
                    resultArray[row, col] = test.ToInt() + (int)b[row, col];
                }
            }
        }
        else if (typeof(string) == typeof(T))
        {

        }
        else
        {

        }


        return resultArray;
    }
}
