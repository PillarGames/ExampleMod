using UnityEngine;
using System;

namespace Garva
{
    public class Mod {
        public static void Main() {
            new GameObject("GarvaManager",new Type[] { typeof(GarvaManager) });
        }
    }
}
