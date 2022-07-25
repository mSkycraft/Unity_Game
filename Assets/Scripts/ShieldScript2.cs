using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldScript2 : MonoBehaviour
{
    public BoxCollider2D ShieldColl;
    public Image Shield;
    public int HP, FullHP = 2;
    public static bool ShieldActive;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Shield.fillAmount == 1)
            if (collision.tag.ToString() == "Boll1")
            {
                try
                {
                    Destroy(collision.gameObject);
                }
                catch
                {

                }
                HP -= 1;
            }
    }

    private void Update()
    {
        if(MainScript.GameStarted == true)
        {
            if (ShieldActive == true)
            {
                HP = FullHP;
                Shield.fillAmount = 1;
                ShieldActive = false;
            }

            if (HP <= 0)
            {
                Shield.fillAmount = 0;
            }
        }

    }

    private void Reset()
    {
        
    }
}
