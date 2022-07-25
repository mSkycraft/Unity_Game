using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public float CurrentCd, Cd;
    public bool isLeft = true;
    public GameObject Projectile;
    public Transform shotDir;
    public Transform Parent;
    public string TextTag;

    private Touch touch;
    private Vector2 vector;
    private float rotate = 2f;
    public float speed = 0.05f;
    private void Update()
    {
        if (MainScript.GameStarted == true)
        {
            if (isLeft == false)
            {

                if (CurrentCd > 0)
                    CurrentCd -= Time.deltaTime;
                if (Input.touchCount == 1)
                {
                    if (CanShoot())
                        Shoot();
                    touch = Input.GetTouch(0);
                    vector = touch.position - touch.deltaPosition;
                    if (vector.y > touch.position.y)
                        transform.Rotate(Vector3.back, speed);
                    else
                        if (vector.y < touch.position.y)
                        transform.Rotate(Vector3.back, -speed);
                }
            }
            else
            {
                if (CanShoot())
                    Shoot();
                if (CurrentCd > 0)
                    CurrentCd -= Time.deltaTime;
                transform.Rotate(Vector3.back, rotate * Time.deltaTime);
            }
        }
    }

    bool CanShoot()
    {
        if(TextTag == "Boll1")
        {
            if (HPBarScript.HP1 > 0)
                if (CurrentCd <= 0)
                    return true;
        }
        else
        {
            if (HPBarScript.HP2 > 0)
                if (CurrentCd <= 0)
                    return true;
        }
        return false;
    }

    void Shoot()
    {
        CurrentCd = Cd;
        GameObject proj = Instantiate(Projectile, shotDir.position, shotDir.rotation);
        proj.transform.SetParent(Parent);
        proj.tag = TextTag;
    }
}