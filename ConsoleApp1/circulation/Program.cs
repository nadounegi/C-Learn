using System.ComponentModel.DataAnnotations;

namespace circulation
{
    class Program
    {
        private static void Main(string[] args)
        {
            // 循环语句
            // 1.while语句
            //新年倒数
            int count = 10;
            //while (count > 0)
            //{
            //    Console.WriteLine(count);
            //    count--;
            //}
            //Console.WriteLine("Happy New Year!");

            //do-while语句
            do
            {
                Console.WriteLine(count);
                count--;
            } while (count > 0);

            //1+2+3....+100 = ?
            int i = 1;
            int sum = 0; 
            //do
            //{
            //    sum += i;
            //    i++;
            //} while (i <= 100);

            //Console.WriteLine("結果：{0}", sum);

            //for语句
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("Hello World");
            }

            for (int j = 1; j <= 100; j++)
            {
                sum += j;

            }
            Console.WriteLine(sum);

            //鶏と兔 35头 94脚
            for(int ji = 0; ji <= 35;ji++)
            {
              if (ji*2+(35-ji)*4 == 94)
                {
                    Console.WriteLine("鶏:{0}只，兔:{1}只", ji, 35 - ji);
                }
            }


           }
    }
}