using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LafetScript : MonoBehaviour
{
    public int multipler = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.name == "Lafet1")
        {
            if(collision.tag.ToString() == "Boll2")
            {
                try { 
                Destroy(collision.gameObject);
                }
                catch
                {

                }
                HPBarScript.HP1 -= TurretProjectileScript.Damage * multipler;
                if (HPBarScript.HP1 <= 0)
                {
                    this.GetComponent<BoxCollider2D>().enabled = false;
                }
            }

        }
        else
        {
            if (collision.tag.ToString() == "Boll1")
            {
                try
                {
                Destroy(collision.gameObject);
                }
                catch
                {

                }
                HPBarScript.HP2 -= TurretProjectileScript.Damage * multipler;
                if (HPBarScript.HP2 <= 0)
                {
                    this.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
    }
}
