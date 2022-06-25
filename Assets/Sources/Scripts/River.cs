using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public class River : MonoBehaviour
    {
        private void Awake()
        {
            
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.back * RiverManager.Instance.GetSpeedScrolling() * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == CharactereController.TAG_PLAYER)
            {
                RiverManager.Instance.UpdateMap();
            }
        }
    }
}
