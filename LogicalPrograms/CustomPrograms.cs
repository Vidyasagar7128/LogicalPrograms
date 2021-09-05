using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        int var = -1, rem, binary = 0, i = 1,check=0,result=0;
        String strNum = "";
        List<int> odd = new List<int>();
        public void toBinary()
        {
            int number = int.Parse(Console.ReadLine());
            int num= number;
            while (num != 0)
            {
                rem = num % 2;
                num = num / 2;
                binary = binary + (rem * i);
                i = i * 10;
                var++;
                this.check = (int)Math.Pow(2, var);
                this.odd.Add(this.check);
                Console.WriteLine(this.check);
            }
                Console.WriteLine($"Binary : {binary.ToString()}");
                this.strNum = binary.ToString();
                int len = strNum.Length / 2;
                String swap1 = strNum.Substring(0, len);
                String swap2 = strNum.Substring(len);
                String finalString = String.Concat(swap2, swap1);
                this.result = (int)Convert.ToInt32(finalString, 2);
                Console.WriteLine($"Magic : {this.result}");
            if(this.odd[odd.Count - 1] == result)
            {
                Console.WriteLine($"{this.result} : is Power of 2");
            }
            else
            {
                Console.WriteLine($"{this.result} : is Not Power of 2");
            }
        }
    }
}
