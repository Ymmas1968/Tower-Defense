using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private Button GameOver;

    private void Start()
    {
        GameOver.onClick.AddListener(sceneswitch);
    }
    void sceneswitch()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

}
