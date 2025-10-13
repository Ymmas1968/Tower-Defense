using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int rewardAmount = 10;

    void OnDestroy()
    {
        // Prevents awarding money if game is ending or destroyed in editor
        if (CurrencyManager.Instance != null && Application.isPlaying)
        {
            CurrencyManager.Instance.AddCurrency(rewardAmount);
        }
    }
}
