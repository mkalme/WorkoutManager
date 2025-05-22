using System;

namespace WorkoutManager{
    public static class IdUtilities {
        public static string CreateID() {
            return $"{Guid.NewGuid()}-{DateTime.UtcNow.Ticks}";
        }
    }
}
