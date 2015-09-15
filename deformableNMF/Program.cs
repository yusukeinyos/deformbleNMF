using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvFileIO;
using InoueLab;

namespace deformableNMF
{
    class Program
    {
        static double[,] Y;
        static double[][][] H;
        static double[,] U;
        static double[,] Y_hat;
        static int[][,] P;
        static double mu;

        static int I; //周波数ビン数
        static int J; //時間ビン数
        static int K; //基底数
        static int S; //基底状態数

        static void Main(string[] args)
        {
        }
        //---------------------------------------------------------------------
        static void init()
        {
            Y = CsvFileIO.CsvFileIO.ReadData("");
            I = Y.GetLength(0);
            J = Y.GetLength(1);
            Console.WriteLine("基底数を入力");
            K = int.Parse(Console.ReadLine());
            Console.WriteLine("基底の状態数を入力");
            S = int.Parse(Console.ReadLine());
            H = new double[I][][];
            for (int i = 0; i < H.GetLength(0); i++)
            {
                H[i] = new double[J][];
                for (int j = 0; j < H.GetLength(1); j++)
                {
                    H[i][j] = new double[S];
                }
            }
            U = new double[K, J];
            P = new int[S][,];
            for (int i = 0; i < P.Length; i++)
                P[i] = new int[K, J];


        }
        //---------------------------------------------------------------------
        static void updateH()
        {

        }
        //---------------------------------------------------------------------
        static void updateU()
        {

        }
        //---------------------------------------------------------------------
        static void calcYhat()
        {
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    
                }
            }
        }
        //---------------------------------------------------------------------
        
    }
}
