using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public float speed;
    private Vector2 targetPosition;

    void Start()
    {
        targetPosition = GetRandomTarget();
    }

    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        } else
        {
            targetPosition = GetRandomTarget();
        }
    }

    private Vector2 GetRandomTarget() {
        float xPosition = Random.Range(minX, maxX);
        float yPosition = Random.Range(minY, maxY);
        return new Vector2(xPosition, yPosition);
    }
}
