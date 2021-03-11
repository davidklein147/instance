using System;

namespace Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Court co = new Court();
            
            for (int i = 0; i < co.prisArr.Length; i+=2)
            {
                co.generatePris();
                
                if(Court.seatNum % 20 == 0)
                {
                    Court.year++;
                }
                
            }

            foreach (var item in co.prisArr)
            {
               Console.WriteLine(item.ToString(2000));
                item.getReleaseds(2000); 
            }

            Console.WriteLine(Prisoner.releaseds);
        }
    }
}
