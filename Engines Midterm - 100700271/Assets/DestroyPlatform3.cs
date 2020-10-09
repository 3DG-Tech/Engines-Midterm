using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform3 : MonoBehaviour
{
    public GameObject Player;

    public GameObject Platform3;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("hitting");
            Destroy(Platform3);
        }
    }
}
