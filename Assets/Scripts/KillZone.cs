using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Transform spawn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("AHHHH SEEE MURIOOOO AAAHHHHJAJAJAJAJAJAJA!");
            collision.transform.position = spawn.transform.position;
        }
    }
}
