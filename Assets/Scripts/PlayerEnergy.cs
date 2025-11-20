using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergy : MonoBehaviour
{
    public float energy;
    public float maxEnergy;
    public Image energyBar; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxEnergy = energy;
    }

    // Update is called once per frame
    void Update()
    {
        energy -= Time.deltaTime;
        energyBar.fillAmount = Mathf.Clamp(energy / maxEnergy, 0, 1);
    }
}
