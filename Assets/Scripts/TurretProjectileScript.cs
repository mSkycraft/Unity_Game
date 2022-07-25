using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectileScript : MonoBehaviour
{
    public float speed=500;
    public static int Damage = 1;
    public float DestroyTime = 5;
    public Rigidbody2D rb;


    private void Update()
    {
        if(MainScript.GameStarted == true)
            Move();
    }

    
    private void Move()
    {
        if (MainScript.GameStarted == true)
        {
            Invoke("DestroyProjectile", DestroyTime);
            rb.velocity = transform.right * speed;
        }
        else
        {
            rb.velocity = transform.right * 0;
        }
    }
    private void DestroyProjectile()
    {
        Destroy(this.gameObject);
    }

}
