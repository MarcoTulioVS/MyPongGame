using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    #region VARIABLES

    [Header("Settings")]

    [SerializeField]
    private float speed;

    private float movement;

    [SerializeField]
    private Vector2 limits;
    #endregion

    #region METHODS
    void Update()
    {
        Move();
    }

    private void Move()
    {
        movement = Input.GetAxis("Vertical");

        Vector3 newPos = transform.position + Vector3.up * movement * speed * Time.deltaTime;

        newPos.y = Mathf.Clamp(newPos.y, limits.x, limits.y);

        transform.position = newPos;
    }

    #endregion
}
