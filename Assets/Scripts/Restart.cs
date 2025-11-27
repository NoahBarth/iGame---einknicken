using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject player;
    private bool AllowInput = false;

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            StartCoroutine(waitForFreshInput());
            if (Input.GetKey(KeyCode.RightArrow) && AllowInput)
            {
                SceneManager.LoadScene(0);

            }
            if (Input.GetKey(KeyCode.LeftArrow) && AllowInput)
            {
                Application.Quit();
            }
        }
    }

    private IEnumerator  waitForFreshInput()
    {
        yield return new WaitForSeconds(2);
        AllowInput = true;
    }
}
