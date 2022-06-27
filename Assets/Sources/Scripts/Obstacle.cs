using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public class Obstacle : Actor
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag.Contains("Player"))
            {
                Actor.OnDetectionHandler(this.gameObject,collision.gameObject.GetComponent<Actor>(),Charactere.DIEMETHOD);
                GameModeManager.Instance.isGamePlayed = false;
            }
        }
    }
}
