using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Human : MonoBehaviour
{
    public string MyName;
    private int myAge;
    private float myHeight;
    bool isSolo;
    public void Eat(){
        print("냠냠 먹는다.");
    }
    public void Sleep(){
        print("쿨쿨 잔다.");
    }
    public void PowerPush(){
        print("힘껏 장 내 물질을 밀어낸다..");
    }
    
}
