using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour {

    public UnityEngine.UI.Text dropDisplay;
    public double drops = 0;
    public double dropsperclick = 1;
    public double droprate = 0.5;
    public int interval = 1;
    float nexttime = 0;


	// Update is called once per frame
	void Update () {

        dropDisplay.text = "Drops: " + drops;

        if (Time.time >= nexttime)
        {

            drops -= droprate;

            nexttime += interval;

        }
        

    }


    public void Touched()
    {

        drops += dropsperclick;
        
    }

 

    

}
