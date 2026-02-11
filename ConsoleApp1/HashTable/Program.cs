
using System.Collections;

namespace HashTable
{
    class Program
    {
        private static void Main(string[] args)
        {
            // ハッシュ表の基本操作
            Hashtable ht = new Hashtable();
            Hashtable ht2 = new Hashtable(5);

            // 要素の追加 key(キー)とvalue(値)
            ht.Add(1, "ランページ");
            ht.Add(2, "川村一馬");
            ht.Add(3, "青山陸");
            //hashtableの訪問
            Console.WriteLine(ht[2]);

            //１、全部削除
            ht.Clear();
            Console.WriteLine(ht[2]);
            ht.Add(1, "ランページ");
            ht.Add(2, "川村一馬");
            ht.Add(3, "青山陸");
            //きーにょって、要素を削除
            ht.Remove(1);
            Console.WriteLine(ht[1]);
            Console.WriteLine(ht[2]);
            Console.WriteLine(ht[3]);

            //遍历访问 foreach
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine("{0}:{1}", de.Key, de.Value);
            }

        }
    }
}