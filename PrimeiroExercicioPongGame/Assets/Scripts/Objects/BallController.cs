using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    #region VARIABLES

    [Header("Settings")]
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float speedUp;

    [SerializeField]
    private Vector2 startVelocity;
    
    [Header("References")]
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    #endregion

    #region METHODS
    public void ResetBall()
    {
        transform.position = Vector3.zero;
        rb.velocity = startVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Vector2 invertedPosY = rb.velocity;
            invertedPosY.y = -invertedPosY.y;
            rb.velocity = invertedPosY;
        }

        if (collision.gameObject.tag == "plataform")
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
            rb.velocity*=speedUp;
            gameManager.RandomizeFace(spriteRenderer);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            gameManager.AddPoint(gameManager.wallPlayer.GetComponent<IWallPoint>());
            ResetBall();
        }

        if (collision.gameObject.tag == "pointEnemy")
        {
            gameManager.AddPoint(gameManager.wallEnemy.GetComponent<IWallPoint>());
            ResetBall();
        }
    }

    #endregion
}
