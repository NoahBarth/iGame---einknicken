using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player) transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 10);
    }
}
