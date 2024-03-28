using System.Collections;

namespace generic_Non_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {



          
           

            

            
            
        }
       
        static List<int> genericList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            return list;
        }


        /* Dictionary<string, string> dic = genericDictionary();
           dic["baramati"] = "gunawadi";
           dic.Remove("baramati");

           foreach (var item in dic)
           {
               Console.WriteLine("key:{0}  value:{1}", item.Key, item.Value);
           }
           Console.WriteLine();
           Console.WriteLine(dic["phaltan"]);
           if (dic.ContainsKey("pune"))
           {
               Console.WriteLine(dic["pune"]);

           }
           Console.WriteLine(dic.ElementAt(1));

           */
        static Dictionary<string,string> genericDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("baramati", "medad");
            dictionary.Add("indapur", "abc");
            dictionary.Add("phaltan", "def");

            return dictionary;



        }



        /* Stack<string> stack = genericStack();
            foreach(string item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Push("element 5");

            Console.WriteLine(stack.Peek());

            string pop = stack.Pop();
            Console.WriteLine(pop);
            int cnt = stack.Count();
            Console.WriteLine(cnt);
           */
        static Stack<string> genericStack()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("element 1");
            stack.Push("element 2");
            stack.Push("element 3");

            return stack;
        }



        /* Queue<int> que = genericQueue();
           que.Dequeue();
           foreach(int item in que)
           {
               Console.Write(item + "  ");
           }
           Console.WriteLine(que.Contains(4));

           Console.WriteLine(que.Peek());
          */
        static Queue<int> genericQueue()
        {
            Queue<int> que = new Queue<int>();

            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            return que;
        }




        /* List<int> list = genericList();
          foreach(int ele in list)
          {
              Console.Write(ele + " ");
          }
          Console.WriteLine();
          Console.WriteLine(list[1]);
          Console.WriteLine(list.Count);

          Console.WriteLine(list[1]);
          Console.WriteLine(list.IndexOf(7));

          Console.WriteLine(list.Contains(2));*/
        static ArrayList Non_genericArrayList()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add("saurabh");
            return arr;
        }




        /* Hashtable hash = non_GenericHashtable();

           foreach(DictionaryEntry item in hash)
           {
               Console.WriteLine(item.Key+" "+item.Value);
           }
          */
        static Hashtable non_GenericHashtable()
        {
            Hashtable hash = new Hashtable();

            hash.Add(1, "sau");
            hash.Add(2, 3);
            Console.WriteLine(hash.Contains(2));
            

            return hash;
        }
    }
}
