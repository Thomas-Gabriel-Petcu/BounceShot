using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField]
    private string _entityName;
    public string EntityName { get { return _entityName; } set { _entityName = value; } }

    [SerializeField]
    private float _health;
    public float Health { get { return _health; } set { _health = value; } }

    public abstract bool TakeDamage(float damage);
    public abstract void Die();
    public virtual void Heal(float value) { }

    
}
