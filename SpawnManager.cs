using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float spawnTime = 0f;
    public float delay = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime>= delay && Player.isAlive)
        {
            GameObject enemyClone = Instantiate(enemy)as GameObject;
            enemyClone.transform.position = new Vector3(Random.Range(-20f,40f), 0.0f, 100f);
            spawnTime -=delay;
        }
    }
}
