using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int health;
   
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("taking damage");
        CheckHealth();
    }
    
    private void CheckHealth()
    {
        if (health < 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("Enemy killed");
    }
}
