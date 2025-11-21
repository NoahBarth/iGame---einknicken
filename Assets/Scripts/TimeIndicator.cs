using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeIndicator : MonoBehaviour
{
    public bool isColliding;
    public float time;
    public float maxTime;
    public Image timeBar; 
    public event Action EventclimbTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
            time += Time.deltaTime*40;
            timeBar.fillAmount = Mathf.Clamp(time / maxTime, 0, 1);

            if(time >= maxTime)
            {
                // Invoke Event to Player
                Debug.Log("Full time");
                EventclimbTrigger?.Invoke();
            }
        } 
        else
        {
            time = 0;
            timeBar.fillAmount = Mathf.Clamp(time / maxTime, 0, 1);
            
        }
    }
}
