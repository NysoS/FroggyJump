using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public class GameModeManager : MonoBehaviour
    {
        public static GameModeManager Instance { get; private set; }
        public bool isGamePlayed{get; set;}

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        }

            // Start is called before the first frame update
        void Start()
        {
            Instance.isGamePlayed = true;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
