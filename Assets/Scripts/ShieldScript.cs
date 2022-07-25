using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShieldScript : MonoBehaviour
{
    public BoxCollider2D ShieldColl;
    public Image Shield;
    public int HP, FullHP = 2;
    public static bool ShieldActive;
    private bool HaveActivate = true;
    private float ShieldCd = 15, CurrentShieldCd;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Shield.fillAmount == 1)
            if (collision.tag.ToString() == "Boll2")
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
                CurrentShieldCd = ShieldCd;
                HaveActivate = false;
                ShieldActive = false;
            }

            if (CurrentShieldCd <= 0)
            {
                HaveActivate = true;
            }
            else if (CurrentShieldCd <= 5)
            {
                Shield.fillAmount = 0;
            }
            else
            {
                CurrentShieldCd -= Time.deltaTime;
            }

            if (HP <= 0)
            {
                Shield.fillAmount = 0;
            }
            if (Random.Range(0, 100) > 50)
            {
                if (HaveActivate == true)
                    ShieldActive = true;
            }
        }
    }
}
