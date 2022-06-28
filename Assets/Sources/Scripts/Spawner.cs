using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public class Spawner : Actor
    {

        [SerializeField]
        private GameObject[] spawnPoints;

        [SerializeField]
        private int maxObstacle = 2;

        [SerializeField]
        private ActorData[] obstaclesActor;
        [SerializeField]
        private ActorData[] collectableActor;

        private int nbSpawnObstacle = 0;

        private River river;

        private void Awake()
        {
            river = GetComponentInParent<River>();
        }

        private void OnEnable()
        {
            if (river)
                river.onSpawning += SpawnObject;
        }

        private void OnDisable()
        {
            if (river)
                river.onSpawning -= SpawnObject;
        }

        // Start is called before the first frame update
        void Start()
        {
            SpawnObject();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void ResetComponentSpawnObject()
        {
            foreach (GameObject go in spawnPoints)
            {
                go.GetComponent<MeshFilter>().sharedMesh = null;
                go.GetComponent<MeshCollider>().sharedMesh = null;
                go.GetComponent<MeshRenderer>().material = null;
                go.GetComponent<Transform>().localRotation = Quaternion.Euler(Vector3.zero);
                if (go.GetComponent<Obstacle>())
                {
                    Destroy(go.GetComponent<Obstacle>());
                }
                go.transform.position = new Vector3(go.transform.position.x,-2f, go.transform.position.z);
            
            }
        }

        void SpawnObject()
        {
            ResetComponentSpawnObject();

               nbSpawnObstacle = maxObstacle;
            for(int i = 0; i < nbSpawnObstacle; i++)
            {
                foreach (GameObject go in spawnPoints)
                {
                    int rdnSpawn = Random.Range(0, 2);
                    if(nbSpawnObstacle > 0 && rdnSpawn == 1)
                    {
                        ActorData obstacle = obstaclesActor[Random.Range(0, obstaclesActor.Length)];

                        Mesh mesh = new Mesh();
                        mesh = obstacle.gameObject.GetComponent<MeshFilter>().sharedMesh;
                        go.GetComponent<MeshFilter>().sharedMesh = mesh;
                        go.GetComponent<MeshCollider>().sharedMesh = mesh;
                        go.GetComponent<MeshRenderer>().sharedMaterials = obstacle.gameObject.GetComponent<MeshRenderer>().sharedMaterials;
                        go.GetComponent<Transform>().localRotation = obstacle.gameObject.transform.localRotation;
                        go.GetComponent<Transform>().localScale = obstacle.gameObject.transform.localScale;
                        go.AddComponent<Obstacle>();
                        nbSpawnObstacle--;
                    }
                }
            }
        }
    }
}
