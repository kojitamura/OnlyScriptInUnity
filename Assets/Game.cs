using System.Collections;
using System.Collections.Generic;
using Unity = UnityEngine;

namespace OnlyScript
{
    public class Game : Unity.MonoBehaviour
    {
        [Unity.RuntimeInitializeOnLoadMethod]
        static void Initialize()
        {
            new Unity.GameObject("Game", typeof(OnlyScript.Game));
        }

        IEnumerator Start()
        {
            new Unity.GameObject("Camera", typeof(OnlyScript.Camera));

            while (true)
            {
                new Unity.GameObject("Entity", typeof(OnlyScript.Entity));
                yield return null;
            }
        }
    }
}
