using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public GameObject Player;

    public GameObject Platform1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("hitting");
           Destroy(Platform1);
        }
    }
}
