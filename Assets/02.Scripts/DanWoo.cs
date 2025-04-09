using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;

public class DanWoo : Human
{

    void Start()
    {
        MyName ="박단우";
        
        Debug.Log(MyName);
        Eat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
