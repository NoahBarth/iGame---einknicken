using TMPro;
using UnityEngine;

public class Key : MonoBehaviour
{
    public TextMeshProUGUI textField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textField.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player") && !other.gameObject.GetComponent<PlayerController>().hasKey)
        {
            other.gameObject.GetComponent<PlayerController>().hasKey = true;
            Destroy(gameObject);
        } 
        else
        {
            textField.text = "You can only carry 1 key at a time";
            textField.enabled = true;
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        textField.enabled = false;
    }
}
