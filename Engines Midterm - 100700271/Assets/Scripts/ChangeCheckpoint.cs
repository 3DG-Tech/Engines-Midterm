using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject previousCheckpoint;

    public GameObject Player;

    public GameObject plugins;

    static float lastTime = 0.0f;

    void Start()
    {
        lastTime = Time.time;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {

            float currentTime = Time.time;
            float checkpointTime = currentTime = lastTime;
            lastTime = currentTime;
            Debug.Log(checkpointTime);

            plugins.GetComponent<ManagePlugins>().SaveTimeTest(checkpointTime);


            SaveStats.savedCheckpointTimes[0] = checkpointTime;



            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            Destroy(previousCheckpoint);
           
        }
    }
}
