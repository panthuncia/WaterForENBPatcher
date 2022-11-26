using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterForENBPatcher.Settings {
    class Settings {
        public bool ignoreIdenticalToWinningOverride { get; set; } = false;
        public String WaterForEnbModName { get; set; } = "Water for ENB (Shades of Skyrim).esp";
        public String ModsToSkip { get; set; } = "DynDOLOD.esm;Occlusion.esp;Synthesis.esp;Requiem for the Indifferent.esp;Bashed patch, 0.esp";

    }
}
