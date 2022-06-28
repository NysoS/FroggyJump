using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    [CreateAssetMenu(fileName="DataActor",menuName="ScriptableObjects/Obstacle")]
    public class ObstacleData : ActorData
    {        
        public float spawnChance = 50;
    }
}
