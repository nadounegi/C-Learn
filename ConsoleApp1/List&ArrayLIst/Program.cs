using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace List_and_ArrayLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            //配列の定義　一次元配列＆多次元配列
            //配列の定義　一次元配列　第一種
            int[] arr = new int[5];//配列の長さ
            //配列の要素の代入
            arr[0] = 5;
            arr[1] = 7;
            arr[2] = 6;
            arr[3] = 9;
            arr[4] = 8;

            //配列の定義　一次元配列　第二種
            int[] arr2 = new int[] { 3, 4, 5, 7, 9, 10 };
            //配列の定義　一次元配列　第三種
            int[] arr3 = { 3, 6, 7, 8, 9, 11 };
            //配列の要素の訪問　第一種 for文
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}番目の要素は{1}です", i, arr[i]);
            }
            //配列の要素の訪問　第二種 foreach文
            int idx = 0;
            foreach (int value in arr)
            {
                Console.WriteLine("{0}番目の要素は{1}です", idx, value);
                idx++;
            }
            //配列の最大値をプリンターする

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("最大値は{0}", max);

            //配列の最小値をプリンターする
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("最小値は{0}", min);

            //配列の並べ替え　昇順（小さいから大きい）、降順（大きいから小さい）
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\t\n", arr[i]);
            }
            Array.Reverse(arr);
            int j = 0;
            foreach (int value in arr)
            {

                Console.Write("{0}\t", value);
                j++;

            }
            //ArrayList的定義
            ArrayList al = new ArrayList();//無参数　おすすめ
            ArrayList al2 = new ArrayList(10);//初期長さは10、後は自動的に変える
            //新要素をArrayListに添加する
            al.Add(55);
            al.Add("LDH");
            al.Add(3.1415);
            //ArrayListの訪問
            foreach (Object item in al)
            {
                Console.WriteLine("\n{0}\t", item);
            }
            //要素を挿入する
            al.Insert(2, "EXILE");
            foreach (Object item in al)
            {
                Console.WriteLine("\n{0}\t", item);
            }
            /*ArrayList要素の削除*/
            //1、全部削除
            //al.Clear();
            //foreach (Object item in al)
            //{

            //    Console.WriteLine("{0}",item);
            //}

            ////2、指定要素の削除
            //al.Remove(3.1415);
            //foreach (Object item in al)
            //{

            //    Console.WriteLine("{0}", item);
            //}

            ////3、指定インデックスの要素の削除
            //al.RemoveAt(0);
            //foreach (Object item in al)
            //{

            //    Console.Write("{0}\t", item);
            //}

            //4、部分的な要素の削除
            al.RemoveRange(0, 1);
            foreach (Object item in al)
            {

                Console.Write("{0}\t", item);
            }

            //ArrayList要素の探し
           int [] arr4 = {1,6,7,8,10};
            ArrayList al3 = new ArrayList(arr4);
            //要素がArrayListにそんざいしてるかどうか
            bool exist = al3.Contains(6);
            Console.WriteLine("{0}\n",exist);
            //左から右へ探し
            //int index = al3.IndexOf(6);
            //Console.WriteLine("{0}", index);
           int index = al3.IndexOf(7);
            Console.WriteLine("{0}", index);

            /*
             * 特徴：
             * １、長さが変える　
             * ２、異なる種類の値を保存できます　
             * 3、要素が順番に並んでいる
             */

        }
    }
}