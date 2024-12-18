using System;

namespace DAY7_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            Car c1 = new Car(1, "BMW", 2000.50);
            Car c2 = new Car(2, "Toyota");
            Car c3 = new Car(3);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("====================================================");

            /**
             *  Why does defining a custom constructor suppress the default constructor in C#?
             *  
             *  because the compiler assumes you want full control over object initialization.
             *  It prevents conflicts and ensures objects are created with your specified logic.
             *  To have both, explicitly define the parameterless constructor.
             */

            #endregion

            #region Problem2
            Calculator cl1 =new Calculator();

            Console.WriteLine(cl1.sum(1 ,2));
            Console.WriteLine(cl1.sum(1,2,3));
            Console.WriteLine(cl1.sum(2.5,3.8));
            Console.WriteLine("====================================================");

            /**
             * How does method overloading improve code readability and reusability? 
             * 
             * Method overloading improves code readability by allowing methods with the same name to handle different input types or parameters,
             * making the code intuitive and reducing the need for multiple method names.
             * It enhances reusability by letting a single method name serve multiple purposes, adapting to various use cases without duplicating logic.
             */
            #endregion

            #region Problem3
            //Child ch = new Child(1, 2, 3);

            /**
             * What is the purpose of constructor chaining in inheritance?
             * 
             * Constructor chaining in inheritance ensures that base class constructors are called before derived class constructors,
             * allowing the base class to initialize its properties and resources first.
             * This promotes code reuse and maintains proper initialization across the inheritance hierarchy.
             */
            #endregion

            #region Problem4
            Parent pa1 = new Parent(8, 9);
            Child ch1 = new Child(1, 2, 3);

            Console.WriteLine(pa1.product());
            Console.WriteLine(ch1.product());

            /**
             * How does new differ from override in method overriding? 
             * 
             * new hides the base class method,
             * creating a new implementation that doesn't affect polymorphism,
             * so the base method is called when accessed via a base reference.
             * 
             * override replaces the base method,
             * enabling polymorphism, so the derived method is called even when accessed via a base reference.
             */
            #endregion

            #region Problem5
            Parent pa2 = new Parent(8, 9);
            Child ch2 = new Child(1, 2, 3);
            Console.WriteLine(pa2);
            Console.WriteLine(ch2);
            Console.WriteLine("=========================================");

            /**
             * Why is ToString() often overridden in custom classes? 
             * 
             * ToString() is often overridden in custom classes to provide a meaningful,
             * human-readable string representation of an object, which helps with debugging,
             * logging, and displaying object information.
             */
            #endregion

            #region Problem6
            Rectangle r = new Rectangle(2, 3);
            r.Draw();

            Console.WriteLine(r.Area);
            Console.WriteLine("====================================");

            /**
             *  Why can't you create an instance of an interface directly? 
             *  
             *  You can't create an instance of an interface directly because an interface only defines the structure (methods, properties) without providing implementations.
             *  Instances require concrete implementations, which are provided by classes implementing the interface.
             */
            #endregion

            #region Problem7
            IShape i = new Circle(7);

            i.Draw();
            i.PrintDetails();
            Console.WriteLine("=====================================");

            /**
             * What are the benefits of default implementations in interfaces introduced in C# 8.0? 
             * 
             * Default implementations in interfaces allow adding new methods to existing interfaces without breaking existing implementations.
             * They promote code reuse by providing shared logic directly in the interface while still enabling implementing classes to override the default behavior.
             */
            #endregion

            #region Problem8
            IMovable im = new Car2("BMW");
            im.Move();
            Console.WriteLine("===================================");

            /**
             * Why is it useful to use an interface reference to access implementing class methods? 
             * 
             * Using an interface reference to access implementing class methods promotes flexibility and polymorphism,
             * allowing code to interact with different implementations uniformly without depending on specific class types.
             * This improves modularity and makes the code easier to extend and maintain.
             */
            #endregion

            #region Problem9
            File f = new File("ramzy.txt");
            f.Write();
            f.Read();
            Console.WriteLine("===================================");

            /**
             *  How does C# overcome the limitation of single inheritance with interfaces?
             *  
             * C# overcomes the limitation of single inheritance by allowing a class to implement multiple interfaces.
             * This enables a class to inherit behaviors and contracts from multiple sources,
             * providing flexibility and a way to achieve multiple inheritance-like functionality without the complexities of class hierarchy conflicts.
             */
            #endregion

            #region Problem10
            Rectangle2 r2 = new Rectangle2(2,3);
            r2.Draw();

            Console.WriteLine(r2.CalculateArea());

            /**
             * What is the difference between a virtual method and an abstract method in C#?
             * 
             * A virtual method in C# provides a default implementation that can be overridden in derived classes,
             * while an abstract method has no implementation in the base class and must be implemented by derived classes.
             * Virtual methods allow optional overriding, whereas abstract methods require overriding.
             */
            #endregion
        }
    }
}
