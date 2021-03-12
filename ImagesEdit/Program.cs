using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("person1", 2);
            Person person2 = new Person("person2", 3);
            Person person3 = new Person("person3", 4);

            Console.WriteLine("Enter the number of pictures to edit: ");
            int allImages = Int32.Parse(Console.ReadLine());

            //the total time for which the work will be done.  
            double totalTime =Math.Ceiling((allImages / ((double)1 / person1.Speed + (double)1 / person2.Speed + (double)1 / person3.Speed)));
            Console.WriteLine("The total working time is : {0} minutes ", totalTime);

            int restImage = allImages;
            int speed1 = person1.Speed;
            int speed2 = person2.Speed;
            int speed3 = person3.Speed;

            // show personal work 
            Person.Each_Make(totalTime, restImage, speed1, speed2, speed3);

        }

        
    }  
}
