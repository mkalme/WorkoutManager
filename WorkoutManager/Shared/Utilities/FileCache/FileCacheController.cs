using System;
using System.Collections.Generic;
using CommonUtilities;

namespace WorkoutManager {
    public class FileCacheController : IFileCacheController {
        public string Directory { get; init; }

        private IDictionary<string, IFileCache> _cache = new Dictionary<string, IFileCache>();

        public IFileCache CreateCache(string fileName) {
            FileCache cache = new FileCache() {
                FileName = fileName,
                CacheController = this
            };

            _cache.Add(fileName, cache);

            return cache;
        }

        public void SaveAll() {
            foreach (var cache in _cache.Values) {
                cache.Save();
            }
        }
        public bool TryGetCache(string fileName, out IFileCache cache) {
            return _cache.TryGetValue(fileName, out cache);
        }
        public void RemoveCache(string fileName) {
            _cache.Remove(fileName);
        }
    }
}
