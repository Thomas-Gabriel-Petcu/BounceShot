using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    #region fieldsAndProperties
    IEnemyMoveStrategy iEnemyMoveStrategy;
    public Rigidbody2D rb;
    public float speed;
    [SerializeField]
    private float _damage;
    public float Damage { get { return _damage; } }
    #endregion
    public override bool TakeDamage(float damage)
    {
        Health -= damage;
        return true;
    }
    public override void Die()
    {
        ScoreManager.Instance.IncreaseScore(10);
        Destroy(gameObject);
    }
    public override void Heal(float value)
    {
        base.Heal(value);
        //this enemey doesn't heal
    }
    public void SetMoveStrategy(IEnemyMoveStrategy iEnemyMoveStrategy)
    {
        this.iEnemyMoveStrategy = iEnemyMoveStrategy;
    }
    private void Update()
    {
        if (this.Health <= 0) Die();
    }
    private void FixedUpdate()
    {
        iEnemyMoveStrategy.Move(rb, speed);
        //rb.velocity = new Vector2(-speed,0);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "DefenseObjective":
                //deal damage
                DefenseObjective defObj = collision.gameObject.GetComponent<DefenseObjective>();
                defObj.Redify();
                defObj.TakeDamage(Damage);
                Destroy(gameObject);
                break;
            case "PlayerProjectile(Clone)":
                //take damage
                TakeDamage(collision.gameObject.GetComponent<PlayerProjectile>().Damage);
                Destroy(collision.gameObject);
                break;
            default:
                break;
        }
    }
}
