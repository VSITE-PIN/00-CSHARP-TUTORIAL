namespace _03_OOP
{
    internal class Inheritance
    {
        // TODO 44: Create Inheritance constructor.
        public Inheritance()
        {
            Animal animal = new Animal();
            animal.name = "Animal";
            animal.display();
            animal.eat();

            Dog dog = new Dog();
            dog.name = "Dog";
            dog.display();
            dog.getName();
            dog.eat();
        }

        // TODO 45: Create Animal class with name field and display method.
        class Animal
        {

            public string name;

            public void display()
            {
                Console.WriteLine("I am an animal");
            }

            public virtual void eat()
            {

                Console.WriteLine("I eat food");
            }

        }

        // TODO 46: Create Dog class that inherits from Animal class with getName method.
        class Dog : Animal
        {

            public void getName()
            {
                Console.WriteLine("My name is " + name);
            }

            public override void eat()
            {
                Console.WriteLine("I eat bones");
            }
        }
    }
}
