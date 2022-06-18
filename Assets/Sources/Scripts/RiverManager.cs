using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public class RiverManager : MonoBehaviour
    {
        public static RiverManager Instance { get; private set; }

        [SerializeField]
        private List<GameObject> maps;

        [SerializeField]
        private float offset = 15f;

        [SerializeField]
        private float scrolling = 2f;
        [SerializeField]
        private float speedScrolling = 0.01f;

        private void Awake()
        {
            if(Instance != null && Instance != this)
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
        
        }

        // Update is called once per frame
        void Update()
        {
            scrolling += speedScrolling * Time.deltaTime;
        }

        public void UpdateMap()
        {
            GameObject map = maps[0];
            maps.Remove(map);
            float newPos = maps[maps.Count - 1].transform.position.z + offset;
            map.transform.position = new Vector3(0, 0, newPos);
            maps.Add(map);
        }

        public float GetSpeedScrolling()
        {
            return scrolling;
        }
    }
}
