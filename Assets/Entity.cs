using System.Collections;
using System.Collections.Generic;
using Unity = UnityEngine;

namespace OnlyScript
{
    public class Entity : Unity.MonoBehaviour
    {
        void Awake()
        {
            transform.position = new Unity.Vector3(Unity.Random.Range(-10f, 10f), 10f, 0f);

            Unity.MeshFilter mf = gameObject.AddComponent<Unity.MeshFilter>();
            mf.mesh = Unity.Resources.GetBuiltinResource<Unity.Mesh>("Cube.fbx");

            Unity.MeshRenderer mr = gameObject.AddComponent<Unity.MeshRenderer>();
            #if UNITY_EDITOR
            mr.material = UnityEditor.AssetDatabase.GetBuiltinExtraResource<Unity.Material>("Default-Material.mat");
            #else
            mr.material = Unity.Resources.GetBuiltinResource<Unity.Material>("Default-Material.mat");
            #endif

            gameObject.AddComponent<Unity.Rigidbody>();

            gameObject.AddComponent<Unity.BoxCollider>();
        }
    }
}
