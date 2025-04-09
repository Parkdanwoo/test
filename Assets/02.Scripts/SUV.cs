using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUV : Car
{
    void Start()
    {
        setCompany("Lamborghini");
        Debug.Log(getCompany());
        setYear(2022);
        Debug.Log(getYear());
        setmodeName("Urus S");
        Debug.Log(getmodeName());
        setisAccident(false);
        Debug.Log(getisAccident());
    }

    void Update()
    {
        
    }
}
