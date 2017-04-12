using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour {

    

    public int uppiMääräT = 0;
    public double costT = 100;

    

    public void uppiTupla()
    {
         
        /*if (drops >= costT)
        {
            uppiMääräT += 1;
            
            switch (uppiMääräT)
            {
            case 1: dropsperclick = 2; costT = 200; break;
            case 2: dropsperclick = 4; costT = 400;break;
                
            }
            drops -= costT;
       }*/
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        GameObject.Find("ClickButton").GetComponent<Click>().drops -= 100;
    }


}
