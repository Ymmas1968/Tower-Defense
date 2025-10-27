using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(sceneswitch);
    }
    void sceneswitch()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
