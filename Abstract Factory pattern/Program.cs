using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Factory_pattern
{
    class Program
    {
        //Entering value in a console appliaction
        static void Main(string[] args)
        {
            // Create and run the African animal world

            AgeFactory millennials = new millenialFactory();
            Shoppinglstore Store  = new Shoppinglstore(millennials);
            Store.RunBuyprocess();

            AgeFactory Boomer = new BoomerFactory();
            Store = new Shoppinglstore(Boomer);
            Store.RunBuyprocess();

            // Wait for user input

            Console.ReadKey();
        }
    }
    /// <summary>

    /// The 'AbstractFactory' abstract class

    /// </summary>

    abstract class AgeFactory

    {
        public abstract Female CreateFemale();
        public abstract Male CreateMale();
    }

    /// <summary>

    /// The 'ConcreteFactory1' class

    /// </summary>

    class millenialFactory : AgeFactory

    {
        public override Female CreateFemale()
        {
            return new makeup();
        }
        public override Male CreateMale()
        {
            return new Games();
        }
    }
    /// <summary>

    /// The 'ConcreteFactory2' class

    /// </summary>

    class BoomerFactory : AgeFactory

    {
        public override Female CreateFemale()
        {
            return new ointments();
        }
        public override Male CreateMale()
        {
            return new alcohol();
        }
    }

    /// <summary>

    /// The 'AbstractProductA' abstract class

    /// </summary>

    abstract class Female

    {
        public abstract void Buy(Female f);
    }

    /// <summary>

    /// The 'AbstractProductB' abstract class

    /// </summary>

    abstract class Male

    {
        public abstract void Buy(Male h);
    }

    /// <summary>

    /// The 'ProductA1' class

    /// </summary>

    class makeup : Female

    {
        public override void Buy(Female f)
        {
            // Eat Wildebeest

            Console.WriteLine("Young Female" +
              " Buys " + f.GetType().Name);
        }

    }

    /// <summary>

    /// The 'ProductB1' class

    /// </summary>

    class Games : Male

    {
        public override void Buy(Male h)
        {
            // Eat Wildebeest

            Console.WriteLine("Young Male" +
              " Buys " + h.GetType().Name);
        }
    }


    /// <summary>

    /// The 'ProductA2' class

    /// </summary>

    class ointments : Female

    {
        public override void Buy(Female f)
        {
            // Eat Wildebeest

            Console.WriteLine("Young Female" +
              " Buys " + f.GetType().Name);
        }

    }

    /// <summary>

    /// The 'ProductB2' class

    /// </summary>

    class alcohol : Male

    {
        public override void Buy(Male h)
        {
            // Eat Bison

            Console.WriteLine("Old male" +
              " Buys " + h.GetType().Name);
        }
    }
    /// <summary>

    /// The 'Client' class 

    /// </summary>

    class Shoppinglstore

    {
        private Female _female;
        private Male _male;

        // Constructor

        public Shoppinglstore(AgeFactory factory)
        {
            _male = factory.CreateMale();
            _female = factory.CreateFemale();
        }

        public void RunBuyprocess()
        {
            _male.Buy(_male);

            _female.Buy(_female);
        }
    }

}


// Inspired by:
//https://www.dofactory.com/net/abstract-factory-design-pattern


