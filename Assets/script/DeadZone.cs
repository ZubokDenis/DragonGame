using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private PlatformMpve player;

    private void Start()
    {
        //player = GetComponent<PlatformMpve>();
        //player.transform.position = new Vector2(-1.18, -1.320436);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }

}
