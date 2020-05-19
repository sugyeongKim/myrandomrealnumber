using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(0, 200), user;
            Console.WriteLine(num);

            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                user = int.Parse(Console.ReadLine());

                if (user > num)
                {
                    Console.WriteLine(user + "보다는 작습니다");
                }
                else if (user < num)
                {
                    Console.WriteLine(user + "보다는 큽니다");
                }
                else
                {
                    Console.WriteLine("정답입니다~!");
                    break;
                }

                Console.WriteLine("");
            }
        }
    }
}
