using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public float difficultyTime;
    public float minSpeed, maxSpeed;
    public GameObject gameOverPanel = null;

    private float speed;
    private Vector2 targetPosition;

    void Start()
    {
        targetPosition = GetRandomTarget();
    }

    void Update()
    {
        MovePlanet();
    }

    private void MovePlanet()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomTarget();
        }
    }

    private Vector2 GetRandomTarget() {
        float xPosition = Random.Range(minX, maxX);
        float yPosition = Random.Range(minY, maxY);
        return new Vector2(xPosition, yPosition);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Planet")
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    private float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / difficultyTime);
    }
}
