using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthControler : MonoBehaviour
{
    [Header("Players health")]
    [Tooltip("Define what you want your players health to be")]
    public float playerHealth = 100;

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
            SceneManager.LoadScene("TheEnd");
            
        }
    }


}
