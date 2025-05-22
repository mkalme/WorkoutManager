using System;
using System.Collections.Generic;
using BinaryObjectFormat;

namespace WorkoutManager {
    public class ExerciseManager {
        public IList<ExerciseTemplate> ExerciseTemplates { get; set; }
        public IList<PerformedExercise> PerformedExercises { get; set; }

        public ObjectTag Serialize() {
            return new ObjectTag() {
                { "Templates", ExerciseTemplates.Serialize(x => x.Serialize()) },
                { "Exercises", PerformedExercises.Serialize(x => x.Serialize()) }
            };
        }
        public static ExerciseManager Deserialize(ObjectTag tag) {
            IList<ExerciseTemplate> templates = ((ObjectTag[])tag["Templates"]).Deserialize(x => ExerciseTemplate.Deserialize(x));

            return new ExerciseManager() {
                ExerciseTemplates = templates,
                PerformedExercises = ((ObjectTag[])tag["Exercised"]).Deserialize(x => PerformedExercise.Deserialize(x, templates))
            };
        }
    }
}
