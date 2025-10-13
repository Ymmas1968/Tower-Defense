using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager Instance;

    [Header("Currency Settings")]
    public int startingCurrency = 100;
    public int currentCurrency;

    [Header("UI (optional)")]
    public TextMeshProUGUI currencyText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        currentCurrency = startingCurrency;
        UpdateUI();
    }

    public void AddCurrency(int amount)
    {
        currentCurrency += amount;
        UpdateUI();
    }

    public bool SpendCurrency(int amount)
    {
        if (currentCurrency >= amount)
        {
            currentCurrency -= amount;
            UpdateUI();
            return true;
        }
        else
        {
            Debug.Log("Not enough currency!");
            return false;
        }
    }

    void UpdateUI()
    {
        if (currencyText != null)
            currencyText.text = "Currency: " + currentCurrency;
    }
}
