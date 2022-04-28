using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveStrategy : IEnemyMoveStrategy
{
    public void Move(Rigidbody2D rb, float speed)
    {
        rb.velocity = new Vector2(-speed, 0);
    }
}
