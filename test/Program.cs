using System;
using System.Numerics;

namespace Test {
    class Program {
        static void Main() {
            /* Robot bob = new Robot();
            bob.name = "Bob";
            bob.weight = 800;
            bob.coordinates = new byte [] {18, 15, 25};
            Console.WriteLine(bob.name + "weight: " + bob.weight);

            Robot killer = new Robot();
            killer.weight = 1000;
            killer.name = "Killer";
            killer.coordinates = new byte[] {35, 25, 46};
            Console.WriteLine(killer.name + "weight: " + killer.weight); */

            Robot bob = new Robot();
            bob.setValues("Bob", 800, new byte [] {18, 15, 25});
            bob.printValues();

            Robot killer = new Robot();
            bob.setValues("Killer", 1000, new byte [] {35, 25, 46});
            bob.printValues();
        }
    }
}