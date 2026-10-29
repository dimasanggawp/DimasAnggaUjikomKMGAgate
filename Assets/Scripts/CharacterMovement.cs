using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Renderer gamePlayArea;
    [SerializeField] private GameObject misileGameObject;
    private float minX, maxX, yPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = transform.position.y;
        float halfWidth = GetComponentInChildren<SpriteRenderer>().bounds.extents.x;
        Camera mainCamera = Camera.main;
        float camHalfWidth = mainCamera.orthographicSize * mainCamera.aspect;
        float camLeft = mainCamera.transform.position.x - camHalfWidth;
        float camRight = mainCamera.transform.position.x + camHalfWidth;

        Bounds area = gamePlayArea.bounds;
        minX = Mathf.Min(area.min.x, camLeft) + halfWidth;
        maxX = Mathf.Max(area.max.x, camRight) - halfWidth;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        Fire();
    }

    void PlayerMovement()
    {
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = Mathf.Clamp(cursorPosition.x, minX, maxX);
        transform.position = new Vector3(x, yPos, 0);
    }

    void Fire()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(misileGameObject, transform.position, transform.rotation);
        }
    }
}
