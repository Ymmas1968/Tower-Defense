using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public int money;
    [SerializeField] private TextMeshProUGUI moneyTxt;

    private void Start()
    {
        UpdateUi(); 
    }

    public void AddMoney(int a)
    {
        money += a;
        UpdateUi(); 
    }

    private void UpdateUi()
    {
        moneyTxt.text = money.ToString();
    }

    public void RemoveMoney(int a)
    {
        money -= a;
        UpdateUi() ;
    }
}
