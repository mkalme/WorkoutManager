using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutManagerGUI {
    public class Item {
        public Item Parent { get; }
        
        public string DisplayText { get; set; }
        public IList<Item> Children { get; set; }
    }
}
