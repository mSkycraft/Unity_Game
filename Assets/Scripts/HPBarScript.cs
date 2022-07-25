using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarScript : MonoBehaviour
{
    public static float HP1 = 10, HP2 = 10;
    public float FullHP = 10;
    public Image img1;
    public Image img2;

    private void Update()
    {
        img1.fillAmount = HP1 / FullHP;
        img2.fillAmount = HP2 / FullHP;
    }
}