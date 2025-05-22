using System;
using System.Collections.Generic;
using System.Linq;
using BinaryObjectFormat;

namespace WorkoutManager {
    public class ExerciseTemplate {
        public string ID { get; private set; }
        public IList<string> Names { get; set; }

        public ExerciseTemplate() {
            ID = IdUtilities.CreateID();
        }

        public ObjectTag Serialize() {
            return new ObjectTag() {
                { "ID", ID },
                { "Names", Names.ToArray() },
            };
        }
        public static ExerciseTemplate Deserialize(ObjectTag tag) {
            return new ExerciseTemplate() {
                ID = tag["ID"],
                Names = (string[])tag["Names"]
            };
        }
    }
}
