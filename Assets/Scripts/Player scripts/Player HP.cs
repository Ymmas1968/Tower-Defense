
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Hierarchy;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;

    public int playerHP = 10;

    [SerializeField] private TextMeshProUGUI healthText;
    private void Start()
    {
        healthText.text = playerHP.ToString();  
    }

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        playerHP -= damage;
        Debug.Log("Base HP: " + playerHP);
        healthText.text = playerHP.ToString();

        if (playerHP <= 0)
        {
            Debug.Log("Game Over!");
            // TODO: trigger game over screen or restart

            Destroy(gameObject);
        }
    }
}

