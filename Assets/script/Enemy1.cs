using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;
    //private Animator anim;
    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth > 0)
        {

        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
