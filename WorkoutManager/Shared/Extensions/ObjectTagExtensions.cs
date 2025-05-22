using System;
using System.Collections.Generic;
using System.Linq;
using BinaryObjectFormat;

namespace WorkoutManager {
    public static class ObjectTagExtensions {
        public static ObjectTag[] Serialize<T>(this IEnumerable<T> collection, Func<T, ObjectTag> function) {
            ObjectTag[] tags = new ObjectTag[collection.Count()];

            for (int i = 0; i < tags.Length; i++) {
                tags[i] = function(collection.ElementAt(i));
            }

            return tags;
        }
        public static T[] Deserialize<T>(this ObjectTag[] array, Func<ObjectTag, T> function) {
            T[] outout = new T[array.Length];

            for (int i = 0; i < array.Length; i++) {
                outout[i] = function(array[i]);
            }

            return outout;
        }
    }
}
