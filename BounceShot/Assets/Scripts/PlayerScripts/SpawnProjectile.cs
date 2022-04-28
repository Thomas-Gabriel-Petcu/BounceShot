using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject projectile;

    Quaternion rotation;
    float angle;
    Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rotation = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));
            GameObject go =Instantiate(projectile, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), rotation);
            go.GetComponent<Rigidbody2D>().velocity = direction.normalized * 10;
        }
    }
}
