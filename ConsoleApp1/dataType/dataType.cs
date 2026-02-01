using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataType
{
    enum Gender //枚举 性别
    {
        男,女
    }
    enum Education //枚举 学历
    {
        幼稚園,
        小学,
        中学,
        高校,
        専門学校,
        大学,
        修士,
        博士
    }
    class dataType
    {
        static void Main( string[ ] args)
        {
            int age = 10;//32ビット符号付き整数型
            int temprature = -33; //int は　マイナス値がある
            //uint age2 = -44;//uint は　0と正数のみ
            uint age2 = 33;
            //int num = 3333333333; //エラー　int型の範囲を超えている
            //Int32 num2 = 3333333333; //Int32はintの別名
            Int64 num3 = 3333333333; //64ビット符号付き整数型           
            //int age2 = 2.2; //エラー　int型に小数点以下を代入できない
            /*単精度浮動小数点型 常用于误差较大的场合，
             * 例如体重，身高，比较不耗内存*/
            float weight = 55.5f;//fを付ける必要がある
            /*双精度浮動小数点型 常用于误差较小的场合，
             * 例如精密仪器，航天航空的面积体积距离，耗内存较多
             */
            double mm = 5.1234567890123; 
            char gender = '男'; //文字型　シングルクォーテーションで囲む
            char c = '1'; //文字列は値の代入が必要し、値は一つのみ
            //bool型　true or false,yes or no
            bool ok = true;

            //枚举类型的引用方法
            Gender sex = Gender.男;
            Education e = Education.幼稚園;
            //類型転換 
            /*
             * 隐式转换
             * 以下の条件により、自動的に類型転換できる
             * １、二つの類型が兼容　例えば、int和double兼容
             * ２、目標類型大于源類型　例えば、double型大于int型
             */
            double firstAvg = 71.25; //第一次平均点数
            double secondAvg; //第二次平均点数
            int rise = 2;
            secondAvg = firstAvg + rise;
            Console.WriteLine("第二次平均点数是:" + secondAvg);

            /*
             * 明示的変換
             * 以下の条件により、手動で類型転換する必要がある
             * １、二つの類型が互換性がない　例えば，int和char互換性がない
             * ２、目標類型小于源類型　例えば，int型小于double型
             */
            //1、（類型名）表示式
            //int b = 10.2;//エラー　暗黙的変換できない
            int c2 = (int)10.2; //明示的変換
            Console.WriteLine("c2の値は:" + c2);
            //2、Convert.To類型名(表示式)
            double a = 10;
            int d = Convert.ToInt32(a);
            Console.WriteLine("dの値は:" + d);
            //3、類型名.Parse(字符串)
            double g = 11;
            int f = int.Parse(g.ToString());//不常用
            Console.WriteLine("fの値は:" + f);
            f = int.Parse("12345");
            Console.WriteLine("fの値は:" + f);

            /*
             * 装箱和拆箱
             * 装箱：値类型转换为引用类型的过程
             * 拆箱：引用类型转换为值类型的过程
             */

            //類型転換常见错误
            int age3 = 14;
            char ch2 = '女';
           //char result = age3 + ch2; //エラー　int型とchar型は互換性がない
            int isex = ch2; //char型小于int型，互換性があるので暗黙的変換できる
        }
    }
}
