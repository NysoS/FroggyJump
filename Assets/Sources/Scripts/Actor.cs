using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public class Actor : MonoBehaviour
    {
        public static event Action<GameObject, Actor, string> OnDetection;

        public static void OnDetectionHandler(GameObject source, Actor target, string callback)
        {
            OnDetection?.Invoke(source, target, callback);
        }

        public virtual void OnDetected(GameObject source, Actor target, string callback) { }

    }
}
