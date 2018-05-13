using System;

namespace Course.Generics {
    class Pair<T, U> : IComparable<Pair<T, U>> where T : IComparable<T> where U : IComparable<U> {

        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second) {
            First = first;
            Second = second;
        }

        public int CompareTo(Pair<T, U> other) {
            int firstCompare = First.CompareTo(other.First);
            if (firstCompare != 0) {
                return -firstCompare;
            }
            else {
                return -Second.CompareTo(other.Second);
            }
        }
    }
}
