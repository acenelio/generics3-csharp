using System;

namespace Course.Entities {
    class WrittenTest : IComparable<WrittenTest> {

        public int Questions { get; set; }
        public int Essay { get; set; }

        public WrittenTest(int questions, int essay) {
            Questions = questions;
            Essay = essay;
        }

        public int FinalResult {
            get { return Questions + Essay; }
        }

        public int CompareTo(WrittenTest other) {
            return FinalResult.CompareTo(other.FinalResult);
        }
    }
}
