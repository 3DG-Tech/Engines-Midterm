using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintTime : MonoBehaviour
{

    public GameObject plugins;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        for (int index = 0; index < 6; index++)
        {
            plugins.GetComponent<ManagePlugins>().LoadTimeTest(index);
            float temp = plugins.GetComponent<ManagePlugins>().LoadTimeTest(index);
            this.GetComponent<TextMeshProUGUI>().text = temp.ToString();
        }

    }
}
