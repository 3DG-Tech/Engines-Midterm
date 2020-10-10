using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            //Debug.Log("fell");
            Player.GetComponent<CharacterController>().enabled = false;
            Player.transform.position = checkpoint.position;
            Player.GetComponent<CharacterController>().enabled = true;
        }
    }

}
