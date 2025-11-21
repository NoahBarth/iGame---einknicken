using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject player;
    
    // Update is called once per frame
    void Update()
    {
        if (!player && Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(0);
        }
    }
}
