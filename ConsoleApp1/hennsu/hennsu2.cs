using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hennsu
{
    class Hennsu2
    {
        static int age = 20; //グローバル変量（クラス範囲に有効）
        public static void Run()
        {
            //グローバル変量を使用するために、staticキーワードを付ける必要がある
            age = 30;
            int age2 = 10;//メソッド変量（メソッド範囲に有効）
            Console.WriteLine("年齢は{0}歳です", age2);//メソッド変量を使用
            int count = 3;
            //エラー　初期化されていない変量は使用できない
            //Console.WriteLine("{0}",count);
            Console.WriteLine("{0}", count);
        }
        public static void Main(string[] args)
        {
            Run();

        }
        //void Fun()
        //{
        //    age2 =30; //エラー　メソッド変量は他のメソッドで使用できない
        //}
