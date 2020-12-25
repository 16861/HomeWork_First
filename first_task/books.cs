
using System;

namespace first_task {
    public class Book<T> {
        string _name;
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
        T _price;
        public T Price {
            get {
                return _price;
            }
            set {
                _price = value;
            }
        }

        public void Show() {
            Console.WriteLine("Name: {0}, price: {1}", Name, Price);
        }
    }
}