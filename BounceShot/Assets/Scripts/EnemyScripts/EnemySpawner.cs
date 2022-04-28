using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _enemies;
    [SerializeField]
    private float _positiveY;
    [SerializeField]
    private float _negativeY;

    public bool canSpawn;
    public float spawnWaitSeconds;

    private void Start()
    {
        canSpawn = true;
        StartCoroutine(Spawn());
    }

    private void SpawnEnemy(GameObject obj)
    {
            GameObject enemyGO = Instantiate(obj, transform.position, Quaternion.identity);
            enemyGO.GetComponent<Enemy>().SetMoveStrategy(new EnemyMoveStrategy());
    }

    private void ChangePosition(float lowerClamp, float upperClamp)
    {
        float y = Random.Range(_negativeY,_positiveY);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        if (transform.position.y < _negativeY)
        {
            transform.position = new Vector3(transform.position.x, lowerClamp, transform.position.z);
        }
        else if(transform.position.y > _positiveY)
        {
            transform.position = new Vector3(transform.position.x, upperClamp, transform.position.z);
        }
    }
    IEnumerator Spawn()
    {
        while (canSpawn)
        {
            SpawnEnemy(_enemies[Random.Range(0, 2)]);
            ChangePosition(_negativeY,_positiveY);
            yield return new WaitForSeconds(2);
        }
    }
}
