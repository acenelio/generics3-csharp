using System;
using System.Globalization;
using Course.Generics;

namespace Course.Entities {
    class Contestant : IComparable<Contestant> {

        public string Name { get; set; }

        private Pair<PracticalTest, WrittenTest> _contestData;
        
        public Contestant(string name, WrittenTest writtenTest, PracticalTest practicalTest) {
            Name = name;
            _contestData = new Pair<PracticalTest, WrittenTest>(practicalTest, writtenTest);
        }

        public WrittenTest WrittenTest {
            get { return _contestData.Second; }
        }

        public PracticalTest PracticalTest {
            get { return _contestData.First; }
        }

        public int CompareTo(Contestant other) {
            return _contestData.CompareTo(other._contestData);
        }

        public override string ToString() {
            return Name
                + ", "
                + PracticalTest.FinalResult.ToString("F1", CultureInfo.InvariantCulture)
                + " (practical test), "
                + WrittenTest.FinalResult
                + " (written test)";
        }
    }
}
