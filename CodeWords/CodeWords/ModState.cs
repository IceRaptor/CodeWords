﻿
using System.Collections.Generic;

namespace CodeWords {

    public static class ModState {

        public static Dictionary<string, string> ContractGUIDToCodeName = new Dictionary<string, string>();

        public static void Reset() {
            // Reinitialize state
            ContractGUIDToCodeName.Clear();
        }
    }

}

