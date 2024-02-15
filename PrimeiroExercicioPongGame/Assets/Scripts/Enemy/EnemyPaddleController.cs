using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleController : MonoBehaviour
{
    #region VARIABLES

    [Header("Settings")]
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector2 limits;

    [SerializeField]
    private GameObject ball;
    #endregion

    #region METHODS
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(ball != null)
        {
            float targetY = Mathf.Clamp(ball.transform.position.y,limits.x,limits.y);
            Vector2 newPosition = new Vector2(transform.position.x,targetY);
            transform.position = Vector2.MoveTowards(transform.position,newPosition,Time.deltaTime * speed);
        }
    }

    #endregion
}
