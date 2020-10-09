using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform2 : MonoBehaviour
{
    public GameObject Player;

    public GameObject Platform2;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("hitting");
            Destroy(Platform2);
        }
    }
}
