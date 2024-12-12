using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPoint, obstacleContainer;
    public float spawnTimer=3f,randomnessMultiplier=1f;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() 
    {
        while (true) 
        {
            Vector3 randomness= new Vector3(0,Random.Range(-1f*randomnessMultiplier,1f*randomnessMultiplier),0);
            GameObject lastSpawnedObstacle = Instantiate(obstaclePrefab, spawnPoint.position + randomness, Quaternion.identity);
            lastSpawnedObstacle.transform.parent= obstacleContainer;
            Destroy(lastSpawnedObstacle,15f );
            yield return new WaitForSeconds(spawnTimer);
        }
        
    }
}
