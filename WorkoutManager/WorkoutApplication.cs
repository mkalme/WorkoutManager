using System;
using CommonUtilities;

namespace WorkoutManager {
    public class WorkoutApplication {
        public WorkoutResource WorkoutResource { get; set; }
        public ExerciseManager Manager => WorkoutResource.Manager;

        public string StoragePath => $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage";
        private IFileCacheController _controller;

        public WorkoutApplication() {
            _controller = new FileCacheController() { 
                Directory = StoragePath
            };

            WorkoutResource = new WorkoutResource(_controller);
            WorkoutResource.Load();
        }
    }
}
