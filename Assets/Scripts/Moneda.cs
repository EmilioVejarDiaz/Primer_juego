using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public AudioSource moneda;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("GANASTEEEEEEEEE!!!!!!");
            moneda.PlayOneShot(moneda.clip);
            Destroy(this.gameObject);
        }
    }
}
