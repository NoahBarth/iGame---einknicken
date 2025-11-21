using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject player;
    
    // Update is called once per frame
    void Update()
    {
        if (!player && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(0);
        }
    }
}
