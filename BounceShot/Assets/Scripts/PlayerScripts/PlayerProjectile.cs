using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerProjectile : MonoBehaviour
{
    [SerializeField]
    private float damage;
    public float Damage { get { return damage; } }
    public Rigidbody2D rb;


    private void Start()
    {
        Destroy(gameObject, 2f);
    }
}
