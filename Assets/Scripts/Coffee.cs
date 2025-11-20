using UnityEngine;

public class Coffee : MonoBehaviour
{
    public PlayerEnergy pEnergy;
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
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Restore Energy");
            pEnergy.energy = 100;
            Destroy(gameObject);
        }
    }
}
