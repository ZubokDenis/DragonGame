using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    // Start is called before the first frame update
    public float HealEnemy;
    private Health player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.GetComponent<Health>().currentHealth <3)
        {
            collision.GetComponent<Health>().AddHealth(HealEnemy);
            Destroy(gameObject);
        }
    }
}
