using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Bed : MonoBehaviour
{

    public TextMeshProUGUI textField;

    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision with bed"); 
        if (other.gameObject.CompareTag("Player"))
        {
            textField.text = "SUCCESS\nYou reached your bed. Sweet dreams\nPress '->' to restart\nPress '<-' to quit";
            Destroy(other.gameObject);
            textField.enabled = true;
        } 
    }
}
