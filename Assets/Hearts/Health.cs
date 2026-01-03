using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float startingHealth;
    public float currentHealth;
    private Animator anim;
    public bool dead = false;

    public float iframesDuration;
    public int numberOffFlashes;
    private SpriteRenderer spriteRenderer;
    private Collider2D col2D;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        col2D = GetComponent<Collider2D>();
        rb2D = GetComponent<Rigidbody2D>();

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
        currentHealth = Mathf.Clamp(currentHealth - _damage,0, startingHealth);
        if(currentHealth > 0)
        {
            StartCoroutine(Flashes());
        }
        if (currentHealth <= 0)
        {
            dead = true;
            GetComponent<PlayerController>().enabled = false;
            anim.SetTrigger("dead");
            if (rb2D != null)
            {
                rb2D.velocity = Vector2.zero;
                rb2D.isKinematic = true;
            }
            if (col2D != null)
            {
                col2D.enabled = false;
            }
           

        }
    }
    public void AddHealth(float _value) 
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);

    }
    private IEnumerator Flashes()
    {
        Physics2D.IgnoreLayerCollision(10, 11, true);
        for(int i = 0; i < numberOffFlashes; i++)
        {
            spriteRenderer.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iframesDuration / (numberOffFlashes * 2));
            spriteRenderer.color = Color.white;
            yield return new WaitForSeconds(iframesDuration / (numberOffFlashes * 2));

        }
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }
    
}
