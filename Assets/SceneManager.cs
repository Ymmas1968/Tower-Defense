using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;

public class SceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Button GameOver;
    void Start()
    {
        GameOver.onClick.AddListener(() => {
            SceneManager.LoadScene("SampleScene");
        });
    }

}
