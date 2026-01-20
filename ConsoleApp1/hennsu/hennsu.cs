using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hennsu
{
    class Hennsu
    {
        static void Main(string[ ] args)
        {
            // 变量声明 int 変量類型　age 変数名　20　数値
            //第一种赋值方式 直接赋值
            int age = 20;
            //第二种赋值方式 先声明后赋值
            int age2;
            age2 = 30;
            //変量名の取名規則
            //1.変量名の最初の文字は数字にできない
            //int 3age = 30;  //エラー
            //2.変量名の最初の文字は記号にできない（_を除く）
            int _age = 20;
            //3.変量名はキーワードにできない
            //int int = 20; //エラー
            //4.変量名は大文字と小文字を区別する
            int Age = 25;
            //5.変量名はスペースを含めることができない
            //int my age = 20; //エラー
            //6.＄か％が使えない
            //int $age = 20; //エラー
            //使用変量
            Console.WriteLine("大家好，我今年" + age + "歳");
            Console.WriteLine("大家好，我今年{0}歳",age);
            
        }
    }
}