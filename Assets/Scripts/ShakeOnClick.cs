using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOnClick : MonoBehaviour
{
    [Tooltip("Put an object here to start shaking.")]
    public GameObject make_shake;

    [Tooltip("Maximum tilt = angle_range/2")]
    public int angle_range = 30;

    [Tooltip("Seconds.")]
    public double shake_duration = 0.5;
    double shake_duration_current;
    bool shaking = false;

    // Update is called once per frame
    void Update()
    {
        if(shaking)
        {
            // while there's still time left..
            if((shake_duration_current -= Time.deltaTime) > float.Epsilon)
            {
                // set a random angle.
                float random = Random.value;
                float angle = (angle_range * random) - (angle_range / 2);

                make_shake.transform.eulerAngles = new Vector3(0, 0, angle);
            }
            else
            {
                // set angle back to normal.
                make_shake.transform.eulerAngles = Vector3.zero;
                shaking = false;
            }
        }
    }

    void OnMouseDown()
    {
        StartShaking();
    }

    public void StartShaking()
    {
        shaking = true;
        shake_duration_current = shake_duration;
    }
}
