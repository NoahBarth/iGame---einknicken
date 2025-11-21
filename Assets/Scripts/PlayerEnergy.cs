using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerEnergy : MonoBehaviour
{
    public float energy;
    public float maxEnergy;
    public Image energyBar; 

    public TextMeshProUGUI textField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxEnergy = energy;
    }

    // Update is called once per frame
    void Update()
    {
        energy -= Time.deltaTime * 2;
        energyBar.fillAmount = Mathf.Clamp(energy / maxEnergy, 0, 1);

        if(energy <= 0)
        {
            // Invoke Die Event to Player
            Destroy(gameObject);
            textField.text = "You fell asleep. Press <- + -> to restart";
            textField.enabled = true;
        }
    }
}
