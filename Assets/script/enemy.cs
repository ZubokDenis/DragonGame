using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Patrol Settings")]
    public float moveSpeed = 2f;          // Скорость движения
    public float patrolDistance = 3f;     // Дистанция патрулирования
    public bool startFacingRight = true;  // Начальное направление

    private Vector2 startPosition;        // Начальная позиция
    private bool movingRight;             // Текущее направление
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        movingRight = startFacingRight;
    }

    void Update()
    {
        PatrolMovement();
    }

    void PatrolMovement()
    {
        // Определяем направление движения
        if (movingRight)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        // Проверяем, достиг ли враг границы патрулирования
        if (movingRight && transform.position.x >= startPosition.x + patrolDistance)
        {
            movingRight = false;
            Flip();
        }
        else if (!movingRight && transform.position.x <= startPosition.x - patrolDistance)
        {
            movingRight = true;
            Flip();
        }
    }

    void Flip()
    {
        // Разворачиваем спрайт
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
