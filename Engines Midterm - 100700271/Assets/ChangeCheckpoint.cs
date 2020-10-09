using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject previousCheckpoint;

    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            Destroy(previousCheckpoint);
           
        }
    }
}
