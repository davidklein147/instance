using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class City
    {
        
        public static void Add(Student stu)
        {
            if(unversity.sumStu < unversity.students.Length)
            {
                foreach (var item in unversity.students)
                {
                    if(item == null)
                    {
                        break;
                    }
                    else if(item.ID == stu.ID)
                    {
                        throw new DuplicateRecordException ();
                    }
                   
                }
                              
                unversity.students[unversity.sumStu] = stu;
                unversity.sumStu++;
                
            }
        }

        public static long TuitionSum()
        {
            long sum = 0;
            foreach (var item in unversity.students)
            {
                if (item == null)
                {
                    break;
                }
                sum += item.tuition;
            }
            return sum;
        }

        public static void PrintDetails()
        {
            foreach (var item in unversity.students)
            {
                Console.WriteLine(item);
            }
        }
    }

    class DuplicateRecordException: Exception
    {

    }
}
