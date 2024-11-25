using System.Text;

namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////// 1)

            //Console.WriteLine("Write your name");
            //string res = Console.ReadLine();
            //Console.WriteLine(helloName($"Hello {res}! "));

            ////////////////////////////////////////////// 2)

            //Console.WriteLine("Enter1: ");
            //string textfirs = Console.ReadLine();
            //Console.WriteLine("Enter2: ");
            //string textsecond = Console.ReadLine();
            //Console.WriteLine(makeAbba(textfirs, textsecond));


            ///////////////////////////////////////////////// 3)

            //Console.WriteLine("Enter symbol");
            //string symbol = Console.ReadLine();
            //Console.WriteLine("Write ");
            //string text = Console.ReadLine();
            //Console.WriteLine(makeOutWord(symbol, text));

            /////////////////////////////////////////////////////// 4)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(extraEnd(text));

            ///////////////////////////////////////////// 5)

            //Console.WriteLine("Write");
            //string text = Console.ReadLine();

            //string res = text.Substring(0, 2);
            //Console.WriteLine(res);

            ///////////////////////////////////////// 6)

            //string text = "whowwhow";
            //string res = text.Substring(text.Length/2);
            //Console.WriteLine(res);


            ///////////////////////////////////////// 7)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //string res = text.Substring(1, text.Length - 2);
            //Console.WriteLine(res);


            ////////////////////////////////////// 8)

            //Console.WriteLine("Write");
            //string firstText = Console.ReadLine();
            //Console.WriteLine("Write ");
            //string secondText = Console.ReadLine();

            //if(firstText.Length < secondText.Length)
            //{
            //    Console.WriteLine(firstText + secondText + firstText);
            //}
            //else
            //{
            //    Console.WriteLine(secondText + firstText + secondText);

            //}

            ////////////////////////////////////////// 9)

            //Console.Write("write first text ");
            //string text1 = Console.ReadLine();
            //Console.Write("write second text ");
            //string text2 = Console.ReadLine();
            //Console.WriteLine(nonStart(text1, text2));

            ////////////////////////////////////////////// 10)

            //Console.WriteLine("write first text ");
            //string text = Console.ReadLine();
            //Console.WriteLine(left2(text));

            /////////////////////////////////////////////// 11)

            //Console.WriteLine("write text");
            //string text = Console.ReadLine();
            //Console.WriteLine("enter T or F");
            //bool TF = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(theEnd(text,TF));


            ////////////////////////////////////////////// 12)


            //Console.WriteLine("write text");
            //string text = Console.ReadLine();
            //Console.WriteLine("enter  number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(nTwice(text,num));


            /////////////////////////////////////////////////// 13)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(middleThree(text));


            ///////////////////////////////////////////// 14)


            //Console.Write("write first text ");
            //string text1 = Console.ReadLine();
            //Console.Write("write second text ");
            //string text2 = Console.ReadLine();
            //Console.WriteLine(conCat(text1, text2));


            ////////////////////////////////////////// 15)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(lastTwo(text));


            //////////////////////////////////////////// 16)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(seeColor(text));

            ///////////////////////////////////////////////// 17)


            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(frontAgain(text));


            ////////////////////////////////////////////// 18)


            //Console.Write("write first text ");
            //string text1 = Console.ReadLine();
            //Console.Write("write second text ");
            //string text2 = Console.ReadLine();
            //Console.WriteLine(minCat(text1, text2));


            /////////////////////////////////////////////// 19)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(deFront(text));


            //////////////////////////////////////// 20)


            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(withOutX(text));



            ////////////////////////////////////////////// string 2 //// 1)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(catDog(text));

            //////////////////////////////////////////// 7)


            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(repeatFront(text, num));

            /////////////////////////////////////// 2)

            //Console.WriteLine("write");
            //string text = Console.ReadLine();
            //Console.WriteLine(countCode(text));


            /////////////////////////////////////// 3)


            //Console.Write("write first text ");
            //string text1 = Console.ReadLine();
            //Console.Write("write second text ");
            //string text2 = Console.ReadLine();
            //Console.WriteLine(endOher(text1, text2));


            //////////////////////////////////// 4)
            









            Console.ReadLine();


        }



        static string helloName(string text)
        {
            return text;
        }

        static string makeAbba(string textfirs, string textsecond)
        {
            string res = textfirs + textsecond + textsecond + textfirs;
            return res;
        }

        static string makeOutWord(string symbol, string text)
        {
            StringBuilder sb = new StringBuilder(symbol);
            sb.Insert(2, text);
            return sb.ToString();
        }

        static string extraEnd(string text)
        {
            string res = text.Substring(text.Length - 2);
            string a = "";
            for (int i = 0; i < 3; i++)
            {
                a += res;
            }
            return a;
        }

        static string nonStart(string text1, string text2)
        {
            string resFirst = text1.Substring(1);
            string resFirst2 = text2.Substring(1);
            return resFirst + resFirst2;
        }

        static string left2(string text)
        {
            string res = text.Substring(0, 2);
            string res2 = text.Substring(2);
            return res2 + res;
        }

        static string theEnd(string text, bool TF)
        {
            string res = "";
            if (TF is true)
            {
                res = text.Substring(0, 1);
            }
            else
            {
                res = text.Substring(text.Length - 1);
            }
            return res;
        }

        static string nTwice(string text, int num)
        {
            string res = text.Substring(0, num) + text.Substring(text.Length - num);
            return res;
        }

        static string middleThree(string text)
        {
            string res = text.Substring((text.Length - 2) / 2, 3);
            return res;
        }

        static string conCat(string text, string text2)
        {
            string res = "";
            if (text[text.Length - 1] == text2[0])
            {

                res = text + text2.Substring(1);

            }
            else
            {
                res = text + text2;
            }
            return res;


        }

        static string lastTwo(string text)
        {
            string withOutLastTwo = text.Substring(0, text.Length - 2);
            string lastOne = text.Substring(text.Length - 1);
            string beforeLastOne = text.Substring(text.Length - 2, 1);
            string res = withOutLastTwo + lastOne + beforeLastOne;
            return res;
        }

        static string seeColor(string text)
        {
            string res = text.Substring(0, 3);
            string res2 = text.Substring(0, 4);
            if (res == "red")
            {
                return "red";
            }
            else if (res2 == "blue")
            {
                return "blue";
            }
            else
            {
                return " ";
            }



        }

        static bool frontAgain(string text)
        {
            bool TF;
            string first = text.Substring(0, 2);
            string end = text.Substring(text.Length - 2);

            if (first == end)
            {
                TF = true;
            }
            else
            {
                TF = false;
            }
            return TF;
        }

        static string minCat(string text1, string text2)
        {
            string res = text1.Substring(text1.Length - text2.Length);
            return res + text2;

        }

        static string deFront(string text)
        {
            string res = "";
            if (text[0] == 'a' && text[1] == 'b')
            {
                res = text;
            }
            else if (text[0] == 'a')
            {
                res = text.Remove(1, 1);
            }
            else
            {
                res = text.Remove(0, 2);
            }
            return res;
        }

        static string withOutX(string text)
        {
            if (text[0] == 'x' && text[text.Length - 1] == 'x')
            {
                text = text.Remove(0, 1);
                text = text.Remove(text.Length - 1);
            }
            else if (text[0] == 'x')
            {
                text = text.Remove(0, 1);
            }
            else if (text[text.Length - 1] == 'x')
            {
                text = text.Remove(text.Length - 1);
            }
            return text;
        }

        static bool catDog(string text)
        {

            string[] cat = text.Split("cat");
            string[] dog = text.Split("dog");

            return cat.Length == dog.Length;
        }

        static string repeatFront(string text, int num)
        {
            string res = "";
            for (int i = 0; i < num; i++)
            {
                res += text.Substring(0, num - i);

            }
            return res;
        }

        static int countCode(string text)
        {
            int count = 0;
            for (int i = 0;i < text.Length - 3;i++)
            {
                if(text[i] == 'c' && text[i + 1] == 'o' && text[i + 3] == 'e')
                {
                    count++;
                }
            }
               return count;
        }

        static bool endOher(string text1, string text2)
        {
            if(text1.Length > text2.Length)
            {
                text1 = text1.Substring(text1.Length - 3);

            }
            else
            {
                text2 = text2.Substring(text2.Length - 3);
            }

            if(text1.ToLower() == text2.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
              
             
        }
    }
}

