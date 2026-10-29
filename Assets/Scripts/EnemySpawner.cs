using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyList;
    [SerializeField] private float spawnInterval = 3f;
    [SerializeField] private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnInterval)
        {
            SpawnEnemy(Random.Range(0, enemyList.Count));
            timer = 0f;
        }
    }

    private void SpawnEnemy(int enemyIndex)
    {
        // float xMin = Camera.main.ScreenToWorldPoint(new Vector3(0.1f, 0, 0)).x;
        // float xMax = Camera.main.ScreenToWorldPoint(new Vector3(0.9f, 0, 0)).x;
        // float yPos = Camera.main.ScreenToWorldPoint(new Vector3(0, 1.25f, 0)).y;
        Vector3 SpawnPosition = new Vector3(Random.Range(-8, 8), 6, 0);
        GameObject Enemy = Instantiate(enemyList[enemyIndex], SpawnPosition, transform.rotation);
    }
}
