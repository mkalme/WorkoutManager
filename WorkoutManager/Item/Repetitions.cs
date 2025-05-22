using System;
using BinaryObjectFormat;

namespace WorkoutManager {
    public class Repetitions {
        public int Count { get; set; }
        public float Weight { get; set; }

        public ObjectTag Serialize() {
            return new ObjectTag() {
                { "Count", Count },
                { "Weight", Weight }
            };
        }
        public static Repetitions Deserialize(ObjectTag tag) {
            return new Repetitions() {
                Count = tag["Count"],
                Weight = tag["Weight"]
            };
        }
    }
}
