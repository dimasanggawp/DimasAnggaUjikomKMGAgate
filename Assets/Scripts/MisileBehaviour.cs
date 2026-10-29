using UnityEngine;

public class MisileBehaviour : MonoBehaviour
{
    [SerializeField] private float misileSpeed = 50f;
    [SerializeField] private float misileLifeTime = 3f;
    private const string ENEMY_TAG = "Enemy";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, misileLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        transform.Translate(Vector3.up * misileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }

}
