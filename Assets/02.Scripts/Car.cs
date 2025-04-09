using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private string Company;
    private int year=2002;
    private string modeName;
    private bool isAccident;
    public void Gaspedal(){

    }
    public void BreakPeda(){
        
    }
    public void AI_DriveMode(){
        
    }
    public void setCompany(string Company){
        this.Company = Company;
    }
    public string getCompany(){
        return Company;
    }
    public void setYear(int year){
        this.year = year;
    }
    public int getYear(){
        return year;
    }
    public void setmodeName(string modeName){
        this.modeName = modeName;
    }
    public string getmodeName(){
        return modeName;
    }
    public void setisAccident(bool isAccident){
        this.isAccident = isAccident;
    }
    public bool getisAccident(){
        return isAccident;
    }
}
