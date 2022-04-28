using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseObjective : MonoBehaviour
{
    [SerializeField]
    private float _health;
    public float Health { get { return _health; } set { _health = value; } }
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    public void TakeDamage(float damage)
    {
        Health -= damage;
    }
    public void Redify()
    {
        _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g - 0.2f, _spriteRenderer.color.b - 0.2f, _spriteRenderer.color.a);

    }
}
