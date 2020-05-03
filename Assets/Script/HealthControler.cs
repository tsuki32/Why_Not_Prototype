using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthControler : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private TextMeshProUGUI healthText;

    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {

        healthText.text = playerHealth.ToString("0");

        if (playerHealth <= 0)
        {
            Debug.Log("GAME OVER!");
        }
    }


}
