using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{

    public TextMeshProUGUI textField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player") && other.gameObject.GetComponent<PlayerController>().hasKey)
        {
            other.gameObject.GetComponent<PlayerController>().hasKey = false;
            Destroy(gameObject);
        } 
        else
        {
            textField.text = "Get the key!";
            textField.enabled = true;
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        textField.enabled = false;
    }
}
