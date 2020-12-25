using System;

namespace second_task {
    class MyObject<T> where T : new() {
        public T FactoryMethod() {
            return new T();
        }
    }

    public class MyValueType<T> where T : struct {
        public T FactoryMethod() {
            return new T();
        }
    }
}