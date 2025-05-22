using System;
using BinaryObjectFormat;
using CommonUtilities;

namespace WorkoutManager {
    public class WorkoutResource : Serializeable {
        public ExerciseManager Manager { get; set; }
        public override string ResourceName { get; set; } = "workout";

        public WorkoutResource(IFileCacheController controller) : base(controller) { }

        public override ObjectTag Serialize() {
            return Manager.Serialize();
        }

        public override void SetDefaultState() {
            Manager = new ExerciseManager();
        }
        public override void SetState(ObjectTag obj) {
            Manager = ExerciseManager.Deserialize(obj);
        }
    }
}
