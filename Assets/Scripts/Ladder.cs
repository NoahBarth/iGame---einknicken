using UnityEngine;

public class Ladder : MonoBehaviour
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<TimeIndicator>().isColliding = true;
            
        } 
    }

    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("EXIT COLLISION");
        other.gameObject.GetComponent<TimeIndicator>().isColliding = false;

    }
}
