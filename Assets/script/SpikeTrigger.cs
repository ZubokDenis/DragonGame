using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrigger : MonoBehaviour
{
    [Header("Ссылка на шипы")]
    public Falling[] spikesToDrop;
    // Start is called before the first frame update

    [Header("Настройки")]
    public bool oneTimeUse = true;
    private bool alreadyTriggered = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(oneTimeUse && !alreadyTriggered)
            {
                foreach(Falling spike in spikesToDrop)
                {
                    if(spike != null)
                    {
                        spike.Fall();
                    }
                }
                Debug.Log("spikes is falling");

                alreadyTriggered = true;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1,0,0,0.3f);
        Gizmos.DrawCube(transform.position, transform.localScale);
    }
}
