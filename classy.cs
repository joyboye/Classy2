using System;

namespace classy2
{
    class Program
    
    {
        public static void Main(string[] args)
        {
            var Animal = new Animal();
            Animal.Dog();
            var Animal = new Animal();
            Animal.Cat();

            var prog = new Program();
            prog.Animal();
            prog.Dog();
            int num1 = { 1, 2, 3, 4, 5, 10 };
            prog.num2(num1);
        }

        public class Animal
        {
            
            public int _name { get; set; }
            public int _breed { get; set; }

            public Animal(string breed string name)
            {
                _breed = breed;
                _name = name;
            }

            public void Animal()
            {
                Console.WriteLine("Animal Method successful");
            }

            public void Dog(string dogstring)
            {
                Console.WriteLine("Lions are animals {0}", _name);
                Console.WriteLine(dogstring);
                
            }

            public void Cat(float num1, float num2)
            {
                var outcome = (num1 * num2) / 5;
                Console.WriteLine("The outcome is: {0}", outcome);
               
            }
        }

        public class Dog : Animal
        {
            public string _Breed { get; set; }
            public string _name { get; set; }
            

            public Dog(string name,  string Breed) : Animal
            {
                _name = name;
                
                _Breed = Breed;
            }

            public void run()
            {
                Console.WriteLine("dogs can be big is: {0}", _Breed);
                Console.ReadKey();
            }

            public class Cat : Animal
            {
                public int _SixToed { get; set; }
                public string _name { get; set; }

                public Cat(string name, int SixToed) : base(name, SixToed)
                {
                    _name = name;
                    _SixToed = SixToed;
                }
                public void Animal()
                {

                }

                public void Dog()
                {

                }

                public void Cat ()
                {
                    foreach (int x in cat)

                        if (x == 10)
                        {
                            Console.WriteLine("valid number");
                            
                        }
                        else
                        {
                            Console.WriteLine("invalid number");
                           
                        }
                    
                }
            }
        }
    }
}
