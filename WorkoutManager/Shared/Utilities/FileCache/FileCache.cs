using System;
using BinaryObjectFormat;
using CommonUtilities;

namespace WorkoutManager {
    public class FileCache : IFileCache {
        public IFileCacheController CacheController { get; set; }
        
        public string FileName { get; init; }
        public ObjectTag Cache { get; set; }

        private static object _lock = new object();

        public void Save() {
            lock (_lock) {
                SafeFileUtilities.SaveFileSafely($"{CacheController.Directory}\\{FileName}", Cache.ToBytes());
            }
        }
    }
}
