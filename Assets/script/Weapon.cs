using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform shotPos;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet bulletScript = GetComponent<bullet>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject newBullet = Instantiate(bullet, shotPos.transform.position, transform.rotation);
            bullet bulletScript = newBullet.GetComponent<bullet>();

            if (transform.localScale.x > 0)
            {
                bulletScript.direction = 1;
            }
            else
            {
                bulletScript.direction = -1;
            }

        }
    }

}
