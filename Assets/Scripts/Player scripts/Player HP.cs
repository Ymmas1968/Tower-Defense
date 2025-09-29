
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int playerHP = 10;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        playerHP -= damage;
        Debug.Log("Base HP: " + playerHP);

        if (playerHP <= 0)
        {
            Debug.Log("Game Over!");
            // TODO: trigger game over screen or restart

            GameManager.Instance.TakeDamage(1);
            Destroy(gameObject);
        }
    }
}



