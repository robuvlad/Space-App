using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool moveAllowed;
    private Collider2D collider = null;

    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        movePlanet();
    }

    private void movePlanet()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (collider == touchedCollider)
                {
                    moveAllowed = true;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (moveAllowed == true)
                {
                    transform.position = touchPosition;
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }
        }
    }
}
