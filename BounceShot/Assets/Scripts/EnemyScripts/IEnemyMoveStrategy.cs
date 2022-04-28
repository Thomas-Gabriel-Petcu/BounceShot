using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyMoveStrategy
{
    void Move(Rigidbody2D rb, float speed);
}
