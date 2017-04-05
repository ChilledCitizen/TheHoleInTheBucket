using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour {

    public UnityEngine.UI.Text dropDisplay;
    public UnityEngine.UI.Text dropsPerSec;
    public double drops = 0;
    public double dropsperclick = 1;
    public double droprate = 0;
    public int interval = 1;
    float nexttime = 0;
    float nexttime2 = 0;
    public int snake = 1;
    public int snaketime = 0;
    public int interval2 = 10;
    public double persec = 0;


	// Update is called once per frame
	void Update () {

        dropDisplay.text = "Drops: " + drops;
        dropsPerSec.text = "Per Second: " + persec;

        if (Time.time >= nexttime)
        {

            drops -= droprate;

            nexttime += interval;

        }

        

        if (Time.time >= nexttime2)
        {
            /* switch (snake)
             {
                 case 1: snaketime = 0; break;
                 case 2: snaketime = 1; break;
                 case 3: snaketime = 2; break;
                 case 4: snaketime = 3; break;

             }

             nexttime2 += interval2;
             snake++;

         }
         */
            nexttime2 += interval2;
            snaketime++;


            switch (snaketime)
            {
                case 1: droprate = 0; break;
                case 2: droprate = 0.5; break;
                case 3: droprate = 1; break;
                case 4: droprate = 2; break;
                case 5: droprate = 3.5; break;
                case 6: droprate = 5; break;
                case 7: droprate = 7.5; break;
                case 8: droprate = 10; break;
                case 9: droprate = 15; break;
                case 10: droprate = 20; break;

            }

            if (droprate == 1)
            {

                interval2 = 30;

            }

            if (droprate == 3.5)
            {

                interval2 = 60;

            }

            if (droprate == 5)
            {

                interval2 = 90;

            }

            if(droprate == 10)
            {

                interval2 = 120;

            }

            if (droprate == 20)
            {

                interval2 = 150;

            }

        }

            
        
        

    }


    public void Touched()
    {

        drops += dropsperclick;
        
    }

 

    

}
