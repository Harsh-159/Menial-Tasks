using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime=10f;
    public float fasterSpawn = 0.2f;
    private float curSpawnTime;
    private int spwans;
    // Start is called before the first frame update
    void Start()
    {
        curSpawnTime = Time.time;
        spwans = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > curSpawnTime)
        {
            var newEnemy=(GameObject) Instantiate(enemy, transform.position,Quaternion.identity);
            curSpawnTime = curSpawnTime + spawnTime-fasterSpawn*spwans;
            spwans += 1;
        }
    }
}
