using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class ManagePlugins : MonoBehaviour
{

    const string DLL_NAME = "EnginesDLL";

    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpoiintTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoints();

    float lastTime = 0.0f;

    public void SaveTimeTest(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTimeTest(int index)
    {
        if (index >= GetNumCheckpoints())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpoiintTime(index);
        }
    }

    public float LoadTotalTimeTest()
    {
        return GetTotalTime();
    }

    public void ResetLoggerTest()
    {
        ResetLogger();
    }

    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
        //{
        //   //Debug.Log("space pressed");
        //    float currentTime = Time.time;
        //    float checkpointTime = currentTime = lastTime;
        //    lastTime = currentTime;

        //    SaveTimeTest(checkpointTime);
        //}

        //for(int i = 0; i <10; i++)
        //{
        //    if (Input.GetKeyDown(KeyCode.Alpha0 + i))
        //    {
        //        Debug.Log(LoadTimeTest(i));
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    Debug.Log(LoadTotalTimeTest());
        //}
    }

}
