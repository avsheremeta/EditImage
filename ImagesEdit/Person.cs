using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesEdit
{
    class Person
    {
        private string name;
        private int speed;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                { Console.WriteLine("value must be greater than zero "); }
                else
                { speed = value; }
            }
        }

        public Person(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        // how many photos each worker will edit 
        public static void Each_Make(double allImages, int restImage, int speed1, int speed2, int speed3)
        {
            int makeImages1 = 0;
            int makeImages2 = 0;
            int makeImages3 = 0;

            // check the productivity of each employee for the total time 
            for (int i = 0; i <= allImages; i++)
            {
                if ((i % speed1 == 0) & (i != 0) & restImage != 0)
                {
                    makeImages1 += 1;
                    restImage -= 1;
                }
                if ((i % speed2 == 0) & (i != 0) & restImage != 0)
                {
                    makeImages2 += 1;
                    restImage -= 1;
                }

                if ((i % speed3 == 0) & (i != 0) & restImage != 0)
                {
                    makeImages3 += 1;
                    restImage -= 1;
                }
            }

            Console.WriteLine("Person1 edit: {0} images ", makeImages1);
            Console.WriteLine("Person2 edit: {0} images ", makeImages2);
            Console.WriteLine("Person3 edit: {0} images ", makeImages3);
            Console.ReadLine();
        }
    }
}
