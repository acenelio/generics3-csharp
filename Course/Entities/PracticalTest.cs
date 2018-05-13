using System;

namespace Course.Entities {
    class PracticalTest : IComparable<PracticalTest> {

        public int CompletedTasks { get; set; }
        public int Minutes { get; set; }

        public PracticalTest(int completedTasks, int minutes) {
            CompletedTasks = completedTasks;
            Minutes = minutes;
        }

        public double FinalResult {
            get { return (double)CompletedTasks / Minutes; }
        }

        public int CompareTo(PracticalTest other) {
            return FinalResult.CompareTo(other.FinalResult);
        }
    }
}
