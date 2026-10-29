using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private float enemyLifeTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, enemyLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
