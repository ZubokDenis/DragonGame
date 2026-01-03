using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turrelweapon : MonoBehaviour
{
    [Header("Настройка стрельбы")]
    public Transform shotPos;
    public GameObject bul;
    public float fireRate = 1f;
    public Vector2 shootdirection = Vector2.left;


    private float nextFireTime;
    // Start is called before the first frame update
    void Start()
    {
        
        //shootdirection = shootdirection.normalized;
        //float angel = Mathf.Atan2(shootdirection.y, shootdirection.x)*Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angel, Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    void Shoot()
    {
        Instantiate(bul, shotPos.position, shotPos.rotation);
    }
}
