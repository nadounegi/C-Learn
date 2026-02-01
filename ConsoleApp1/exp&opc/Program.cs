using System.Web;

namespace exp_opc
{
    class Program
    {
        static void Main(string[] args)
        {
            //変量で三つの科目点数を保存
            int C = 89;
            int Math = 92;
            int English = 85;

            //CとMathの点数の差を計算する
            int dif = -(C - Math); 
            //点数の平均数を計算する
            int avg = (C + Math + English) / 3;
            Console.WriteLine("CとMathの点数の差は{0}点で、\n" +
                "三科目点数の平均は{1}点です",dif,avg);

            int a = 12;
            int b = 10;
            Console.WriteLine("余数は{0}です", a % b);
            Console.WriteLine("商は{0}です", a / b);

            //++: 自增
            int c = 1;
            c++;
            Console.WriteLine("{0}",c);

            //不能除以零
            int d = 368;
            int e = 0;
            e = 2;
            int result = d / e;
            Console.WriteLine("結果は{0}です", result);

            int ac = 80;
            int bc = ac;
            Console.WriteLine("bcの点数は{0}点です", bc);

            int f = 18;
            //f += 3; 
            //f &= 3; //fの値は3です
            //f >>= 3; //右移三位，fの値は0です
            //Console.WriteLine("fの値は{0}です", f);
            f %= b - 3;
            Console.WriteLine("fの値は{0}です", f);

            //関係演算子 > < 結果はbool型
            int g = 3, h = 5;
            Console.WriteLine(g > h);//False
            Console.WriteLine(g < h);//True
            Console.WriteLine("{0}",g != h);//True

            //論理演算子 && || !
            //&&: 両方ともTrueのとき、結果はTrue
            bool result1 = (g < h) && (g != h);
            Console.WriteLine(result1);//True
            //||: どちらかがTrueのとき、結果はTrue
            bool result2 = (g < h) || (g == h);
            Console.WriteLine(result2);//True
            //!: TrueをFalseに、FalseをTrueに変える
            bool result3 = !(g < h);
            Console.WriteLine(result3);//False
        }
    }
}