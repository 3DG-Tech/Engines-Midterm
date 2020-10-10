using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EndSceneSwitch : MonoBehaviour
{
    public GameObject Player;

    public GameObject End;

    public GameObject plugins;

    static float lastTime = 0.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {

            float currentTime = Time.time;
            float checkpointTime = currentTime = lastTime;
            lastTime = currentTime;
            Debug.Log(checkpointTime);

            plugins.GetComponent<ManagePlugins>().SaveTimeTest(checkpointTime);


            SaveStats.savedCheckpointTimes[3] = checkpointTime;

            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
