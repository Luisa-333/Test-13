using System;

namespace Test {
    class Robot {
        /* public string name;
        public int weight;
        public byte [] coordinates; */

        private string name;
        private int weight;
        private byte [] coordinates;

        public void setValues (string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }

        public void printValues(){
            Console.WriteLine(name + " weight: " + weight + ". Coordinates: ");
            foreach (byte el in coordinates)
            {
                Console.WriteLine(el);
            }
        }
    }
}