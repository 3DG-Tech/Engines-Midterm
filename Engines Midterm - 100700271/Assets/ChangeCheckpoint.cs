using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject previousCheckpoint;

    public GameObject Player;

    public GameObject plugins;

    float lastTime = 0.0f;

    void Start()
    {
        lastTime = Time.time;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {

            Debug.Log("works");

            plugins.GetComponent<ManagePlugins>().SaveTimeTest(Time.time);

            float currentTime = Time.time;
            float checkpointTime = currentTime = lastTime;
            lastTime = currentTime;

            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            Destroy(previousCheckpoint);
           
        }
    }
}
