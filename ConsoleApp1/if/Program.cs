namespace ifElse
{

    class Program
    {
        static void Main(string[] args)
        {
            // if文の基本構文
            int score = 85;
            score = 55;
            if (score >= 60)
            {
                Console.WriteLine("及格");
            }
            //if-else文
            else
            {
                Console.WriteLine("不及格");
            }
            //if-else else-if文
            string jc = "ICBC";
            if (jc == "ICBC")
            {
                Console.WriteLine("中国工商银行");
            }
            else if (jc == "ABC")
            {
                Console.WriteLine("中国农业银行");
            }
            else if (jc == "BOC")
            {
                Console.WriteLine("中国银行");
            }
            else
            {
                Console.WriteLine("其他银行");

            }
            //switch语句
            int month = 7;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("冬季");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("春季");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("夏季");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("秋季");
                    break;
                default:
                    Console.WriteLine("月份输入错误");
                    break;
            }
        }
    }
}