//   2D Game
//   Tanner Wright
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
namespace Engine.Camera
{
    public class Target : MonoBehaviour
    {
        void MoveTarget(Vector3 to)
        {
            gameObject.transform.position = new Vector3(to.x + 7.2f, to.y + 5.6f, 0f);
        }
    }
}

