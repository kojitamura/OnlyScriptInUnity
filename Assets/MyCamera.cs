using System.Collections;
using System.Collections.Generic;
using Unity = UnityEngine;

namespace OnlyScript
{
    public class Camera : Unity.MonoBehaviour
    {
        void Awake()
        {
            transform.position = new Unity.Vector3(0f, 0f, -10f);

            Unity.Camera c = gameObject.AddComponent<Unity.Camera>();
            c.clearFlags = Unity.CameraClearFlags.SolidColor;
            c.backgroundColor = new Unity.Color(0.5f, 0.75f, 1f);
            c.nearClipPlane = 0.1f;
            c.farClipPlane = 100f;
        }
    }
}
