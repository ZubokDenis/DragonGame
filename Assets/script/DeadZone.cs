using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;

    //private void Start()
    //{
    //    //player = GetComponent<PlatformMpve>();
    //    //player.transform.position = new Vector2(-1.18, -1.320436);
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        collision.gameObject.transform.position = Vector3.zero;
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }

}
