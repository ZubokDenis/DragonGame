using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private DeadZone respawn;
    private BoxCollider2D checkPointCollider;
    void Start()
    {
        //respawn = GetComponent<DeadZone>();
        checkPointCollider = GetComponent<BoxCollider2D>();
        GameObject respawnObject = GameObject.FindGameObjectWithTag("DeadZone");
        if (respawnObject != null)
        {
            respawn = respawnObject.GetComponent<DeadZone>();
            Debug.Log("Yes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            respawn.respawnPoint = this.gameObject;
            //Destroy(gameObject);
            checkPointCollider.enabled = false;
        }
    }
}
