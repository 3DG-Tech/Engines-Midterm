using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStats : MonoBehaviour
{

    public static float[] savedCheckpointTimes = new float[6] { 0, 0, 0, 0, 0, 0 };
    public static float SaveTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    
}
