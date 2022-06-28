using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump { 

    [CreateAssetMenu(fileName = "DataActor", menuName = "ScriptableObjects/Obstacle")]
    public class ActorData : ScriptableObject
    {
        public GameObject gameObject;
    }
}
