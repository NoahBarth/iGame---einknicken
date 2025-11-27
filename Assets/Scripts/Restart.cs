using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            StartCoroutine(waitForFreshInput());
            if (Input.GetKey(KeyCode.RightArrow))
            {
                SceneManager.LoadScene(0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Application.Quit();
            }
        }
    }

    private IEnumerator  waitForFreshInput()
    {
        yield return new WaitForSeconds(3);
    }
}
