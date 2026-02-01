using System.Runtime.Intrinsics.X86;

namespace mojiretu
{
    class Program
    {
        private static void Main(string[] args)
        {
            //文字列と文字型の変量宣言
            int score = 98;
            String name = "张三";//文字列型　ダブルクォーテーションで囲む
            char gender = '男';//文字型　シングルクォーテーションで囲む 一つ文字のみ

            //転義文字の使用
            Console.WriteLine("C:\\Windows");// 転義文字：　\文字　\Wという転義文字がない
            Console.WriteLine("ようこそ\nいらっしゃいませ");
            Console.WriteLine("\tこんばんは");
            Console.WriteLine("\"ここに入力してください\"");
            Console.WriteLine("ここに入力して\bください");//space
            /*
             *  说明：此行使用回车转义字符 '\r'。
             *  回车（'\r'）会将光标移到当前行行首，之后写入的文本会覆盖该行已有内容。
             *  示例：在同一输出中先写入 "ようこそ"，再写入 "\rいらっしゃいませ" 时，多数终端最终会显示 "いらっしゃいませ"（可能覆盖原有字符）。
             *  注意事项：
            // - 如果覆盖的文本比原文本短，可能会留下原文本的尾部残留字符。
            // - 若需要换行，请使用 '\n' 或 `Environment.NewLine`。
            // - 不同平台/终端对 '\r' 的处理可能不同，请在目标环境中确认行为。
             */
             Console.WriteLine("ようこそ\rいらっしゃいませ");
            /*
              * '\f' — form feed（换页符）
              *
              * 说明：
              *  - '\f' 是单个控制字符（U+000C），在 C# 字符串中表示换页符。
              *  - 在历史终端/打印机中用于换页；在现代控制台/终端中通常被忽略或不可见。
              *
              * 用法示例：
              *  Console.WriteLine("第一页\f第二页"); // 多数终端不会产生真正的分页效果
              *  char ff = '\f';
              *  string s = "text" + ff + "more";
              *
              * 注意：
              *  - 逐字字符串（@"..."）不会解析转义序列，@"\f" 会得到反斜线和字母 f，而不是换页符。
              *  - 可使用 "\u000C" 明确按 Unicode 代码点插入换页符。
              *  - 若目的仅为换行或分隔输出，请优先使用 '\n'、Environment.NewLine，或显式打印分隔符（例如空行或一行 '-'）。
              *
              * 建议：
              *  - 不要依赖 '\f' 在控制台产生分页效果；仅在与需要控制字符的设备或协议交互时使用。
              */
             Console.WriteLine("第一页\f第二页");
             Console.WriteLine("\'第一頁\'");

            //文字列Stringの使い方
            name = null; //空値
            name = "趙三";

            /*よくある誤る
             *  // 文档（说明与建议）：
            // - 目的：示例中创建了两个字符串变量并调用了它们的实例方法 ToLower()。
            // - 行为：
            //   * `string str = null;` —— `str` 为 null。对其调用 `str.ToLower()` 会在运行时抛出 System.NullReferenceException。
            //   * `string str2 = "";` —— `str2` 是空字符串。对其调用 `str2.ToLower()` 是安全的，返回仍为 ""（空字符串）。
            // - 建议做法（避免 NullReferenceException）：
            //   1. 在调用实例方法前显式检查 null，例如：
            //        if (!string.IsNullOrEmpty(str)) { var lower = str.ToLower(); }
            //   2. 使用空条件与空合并运算符以获得安全的结果：
            //        var lower = str?.ToLower() ?? string.Empty;
            //      注意：`str?.ToLower()` 在 `str` 为 null 时返回 null，因此常与 `??` 连用以提供默认值。
            //   3. 若不希望受当前区域影响，请改用 `ToLowerInvariant()`。
            //   4. 在项目中启用可空引用类型（如需要）并用类型注解来帮助静态发现这类问题。
            // - 示例替代代码：
            //      string safe1 = str?.ToLowerInvariant() ?? string.Empty; // 安全且不受区域影响
            //      string safe2 = (str2 ?? string.Empty).ToLower();       // 对空字符串安全
            //
            // 总结：永远不要在未确定不为 null 的引用上直接调用实例方法，应使用空检查或空安全操作以防止运行时异常。
             */
            string str = null;
            str = "MIKE";
            string str2 = "";
            str2 = "Joden";
            Console.WriteLine(str.ToLower());
            //str.ToLower();
            //str2.ToLower();
            //文字列達を繋がる
           string str3 = str.ToLower() + str2;
            Console.WriteLine(str3);
            //文字列の比較
            //文字列が空値かどうか
            if(name == "")
            {

            }
            if (name.Equals(string.Empty))
            {

            }
            //他の比較方法
            //二つの文字列の値を比較して、
            //もし英語或いは漢字であったら、
            //辞書中の位置を比較する
            string.Compare(str, str2);//対象方法（メソッド）string.メソッド（）
            str.CompareTo(str2);
            str = "abc";
            str2 = "acc";
            int result = string.Compare(str, str2);
            Console.WriteLine("{0}", result);//-1の場合は、前面は小さい、後面は大きい
            str2 = "abc";
            result = string.Compare(str, str2);
            Console.WriteLine("{0}", result);//0の場合は、両者は同じ
            str = "acc";
            str2 = "abc";
            result = string.Compare(str, str2);
            Console.WriteLine("{0}", result);//1の場合は、前面は大きい、後面は小さい

            //文字列の格式化
            //やり方１
            int a = 1, b = 2, c;
            c = a + b;
            string s = string.Format("{0} + {1} = {2}",a,b,c);
            Console.WriteLine(s);
            //特殊やり方
            DateTime now = DateTime.Now;
            Console.WriteLine("{0:D}",now);//2026年2月1日
            Console.WriteLine(now);//2026/02/01 14:43:43
            Console.WriteLine("{0:d}", now);//2026/02/01
            Console.WriteLine("{0:f}", now);//2026年2月1日 14:45
            Console.WriteLine("{0:F}", now);//2026年2月1日 14:46:02
            string Now = string.Format("{0:D}", now);
            Console.WriteLine(Now);

            //文字列の截取
            string email = "it22083027@tsb-yyg.ac.jp";
            string userId = email.Substring(0, 10);//0番目から10文字を取得
            Console.WriteLine(userId);
            userId = email.Substring(0, email.IndexOf("@"));//"@"の位置を取得して、そこまでの文字を取得
            Console.WriteLine(userId);
            int atIndex = email.IndexOf("@");
            userId = email.Substring(0, atIndex);
            Console.WriteLine(userId);
              
            //文字列の挿入
            name = "zhangsan";
            email = name.Insert(8, "@gmail.com");
            Console.WriteLine(email);

            //文字列の充填
            string s1 = "abc";
            string s2 = s1.PadRight(4,'d');
            s2 = s1.PadLeft(4, '(');
            Console.WriteLine(s2);
            string s3 = s2.PadRight(5, ')');
            Console.WriteLine(s3);

            //文字列の削除
            string domin = email.Remove(0, 8);
            Console.WriteLine(domin);

            //文字列のコピー
            string s4 = "LDH";
            string result2 = string.Copy(s4);//string.Copy()已过时
            Console.WriteLine(result2);

            //文字列の代替
            string aa = "Hello World";
            string bb = aa.Replace("World", "世界");
            Console.WriteLine(bb);
            Console.WriteLine(aa.Replace("World", "世界"));
            Console.WriteLine("abcdabc".Replace('a', 'A'));
        }
    }
}