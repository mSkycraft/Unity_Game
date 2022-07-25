using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TowerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (this.name == "Tower1")
        {
            if (collision.tag.ToString() == "Boll2")
            {
                Destroy(collision.gameObject);
                HPBarScript.HP1 -= TurretProjectileScript.Damage;
                if (HPBarScript.HP1 <= 0)
                {
                    this.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
        else
        if (collision.tag.ToString() == "Boll1")
        {
            Destroy(collision.gameObject);
            HPBarScript.HP2 -= TurretProjectileScript.Damage;
            if (HPBarScript.HP2 <= 0)
            {
                this.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        
    }       

}
