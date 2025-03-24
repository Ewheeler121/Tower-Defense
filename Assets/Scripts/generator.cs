using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public float secondsBetweenEnemies = 3.0f;
    public GameObject enemy;
    public GameObject slow_enemy;

    private float lastEnemyTime;

    // Start is called before the first frame update
    void Start()
    {
        lastEnemyTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastEnemyTime + secondsBetweenEnemies) {
            if(Random.value < 0.8f) {
                Instantiate(enemy, transform.position, Quaternion.identity, null);
            } else {
                Instantiate(slow_enemy, transform.position, Quaternion.identity, null);
            }
            lastEnemyTime = Time.time; 
        }
    }
}
