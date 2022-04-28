using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicatorEnemy : Enemy
{
    [SerializeField]
    private GameObject _spawnable;
    private Vector3 _spawnPosition;
    private bool _canSpawn = false;
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
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private void Update()
    {
        if (Health <=0)
            Die();
    }
    private bool CanSpawn()
    {
        if (_canSpawn = Physics2D.OverlapBox(new Vector2(transform.position.x, transform.position.y + 1), new Vector2(1, 1), 0))
        {
            _spawnPosition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            return true;
        }
        else if(_canSpawn = Physics2D.OverlapBox(new Vector2(transform.position.x, transform.position.y - 1), new Vector2(1, 1), 0))
        {
            _spawnPosition = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            return true;
        }
        return false;
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            if (CanSpawn())
            {
                GameObject obj = Instantiate(_spawnable, _spawnPosition, Quaternion.identity);
                obj.GetComponent<Enemy>().SetMoveStrategy(new EnemyMoveStrategy());
            }
            yield return new WaitForSeconds(2);
        }
    }
}
