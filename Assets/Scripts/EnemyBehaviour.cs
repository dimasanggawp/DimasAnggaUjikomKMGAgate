using UnityEngine;
using System;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private float enemyLifeTime = 3f;
    [SerializeField] private float enemySpeed = 0.5f;
    private const string BULLET_TAG = "Misile";
    private const string PLAYER_TAG = "Player";
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, enemyLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(isAlive)
        {
            //Move();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(BULLET_TAG) && isAlive == true )
        {
            Debug.Log("Collision Detected");
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
    }
}
