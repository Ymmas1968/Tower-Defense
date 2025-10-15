using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int health;
    [SerializeField] private CurrencyManager currencyManager;

    [SerializeField] private int moneyToBeAddedOnDeath = 10;

    private void Start()
    {
        currencyManager = GameObject.FindGameObjectWithTag("CurrencyManager").GetComponent<CurrencyManager>();
    }
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
            currencyManager.AddMoney(moneyToBeAddedOnDeath);
            Destroy(gameObject);
        }
        Debug.Log("Enemy killed");
    }
}
