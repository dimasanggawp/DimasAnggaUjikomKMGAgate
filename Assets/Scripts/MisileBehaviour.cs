using UnityEngine;

public class MisileBehaviour : MonoBehaviour
{
    [SerializeField] private float misileSpeed = 50f;
    [SerializeField] private float misileLifeTime = 3f;
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


}
