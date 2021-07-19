using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Cat ginger = new Cat("Ginger");
            animals.Add(ginger);
            animals.Add(new Cat("Kitty"));
            animals.Add(new Dog("Fido"));
            animals.Add(new Bird("Tweety"));

            MakeAnimalsSpeak(animals);

            Console.WriteLine();

            List<IFlyer> flyers = new List<IFlyer>();

            flyers.Add(new Bird("Tweety"));
            flyers.Add(new Plane());

            foreach(IFlyer flyer in flyers)
            {
                flyer.Fly();
            }

            Console.WriteLine();

            Animal sunbeam = new Cat("Sunbeam");

            // can't do this - need to cast
            //sunbeam.ClimbTree();
            Cat castedCat = (Cat)sunbeam;
            castedCat.ClimbTree();

            Console.WriteLine();

            MakeAnimalsFlyIfPossible(animals);
        }

        private static void MakeAnimalsSpeak(List<Animal> animals)
        {
            foreach(Animal a in animals)
            {
                a.Speak();
            }
        }

        private static void MakeAnimalsFlyIfPossible(List<Animal> animals)
        {
            foreach (Animal a in animals)
            {
                // should try and avoid this kind of code - rethink design
                if(a.GetType() == typeof(Bird))
                {
                    ((Bird)a).Fly();

                    // above code is equivalent to
                    //Bird bird = (Bird)a;
                    //bird.Fly();
                }
            }
        }

    }
}
