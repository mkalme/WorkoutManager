using System;
using System.Collections.Generic;
using BinaryObjectFormat;

namespace WorkoutManager {
    public class Set { 
        public IList<Repetitions> Rep { get; set; }

        public ObjectTag Serialize() {
            ObjectTag[] output = new ObjectTag[Rep.Count];

            for (int i = 0; i < Rep.Count; i++) {
                output[i] = Rep[i].Serialize();
            }

            return new ObjectTag() {
                { "Repetitions", output }
            };
        }
        public static Set Deserialize(ObjectTag tag) {
            return new Set() {
                Rep = ((ObjectTag[])tag["Repetitions"]).Deserialize(x => Repetitions.Deserialize(x))
            };
        }
    }
}
