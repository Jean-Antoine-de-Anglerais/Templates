using UnityEngine;

namespace NativeModloaderTemplate
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