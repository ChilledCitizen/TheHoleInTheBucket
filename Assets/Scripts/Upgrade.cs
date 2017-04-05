using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Upgrade : MonoBehaviour {
    public int up1level;
    public double nexttime = 0;
    public double interval = 10;
    public double up1 = 0;
    public int up1cost = 0;
    public double nexttime2 = 0;
    public double sec = 1;



    Click clack = new Click();

	
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= nexttime)
        {
            if (up1cost < 100)
            {
                switch (up1level)
                {
                    case 0: up1 = 100; break;
                    case 1: up1 = 200; break;

                }
                up1level++;
                up1cost = 0;
            }
                nexttime += interval;
            
            }
       


    }

    public void Kosketus()
    {
        if (clack.drops >= 100)
        {
            up1cost = 100;
            clack.drops -= 100;
        }
    }
}
