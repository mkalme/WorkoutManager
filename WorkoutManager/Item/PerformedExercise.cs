using System;
using System.Collections.Generic;
using System.Linq;
using BinaryObjectFormat;

namespace WorkoutManager {
    public class PerformedExercise {
        public ExerciseTemplate Template { get; set; }

        public IList<Set> Sets { get; set; }
        public DateTime TimePerformed { get; set; }

        public ObjectTag Serialize() {
            return new ObjectTag() {
                { "TemplateID", Template.ID },
                { "Sets", Sets.Serialize(x => x.Serialize()) },
                { "TimePerformed", TimePerformed }
            };
        }
        public static PerformedExercise Deserialize(ObjectTag tag, IEnumerable<ExerciseTemplate> exerciseTemplates) {
            string id = tag["TemplateID"];

            return new PerformedExercise() {
                Template = exerciseTemplates.Where(x => x.ID == id).First(),
                Sets = ((ObjectTag[])tag["Sets"]).Deserialize(x => Set.Deserialize(x)),
                TimePerformed = tag["TimePerformed"]
            };
        }
    }
}
