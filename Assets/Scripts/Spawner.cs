using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPosition;
    public float spawnTimer = 3f, randomnessMultiplier = 1f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObsticle());
    }


    IEnumerator spawnObsticle() 
    {
        while (true) 
        {
            GameObject lastSpawnedGameObject=Instantiate(obstaclePrefab, spawnPosition.position+new Vector3(0,Random.Range(-1f * randomnessMultiplier, 1f * randomnessMultiplier),0),Quaternion.identity);

            Destroy(lastSpawnedGameObject,15f);
            yield return new WaitForSeconds(spawnTimer);
        }
    }
}
