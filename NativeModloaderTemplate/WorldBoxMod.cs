using UnityEngine;

namespace SimpleMod_NativeModloader
{
    public class WorldBoxMod : MonoBehaviour
    {
        static bool initialized = false;

        void Update()
        {
            if (!Config.gameLoaded) return;


            if (!initialized)
            {
                init();
            }

            initialized = true;
        }

        void init()
        {

        }
    }
}