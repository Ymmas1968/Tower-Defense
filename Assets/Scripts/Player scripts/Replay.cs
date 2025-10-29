using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{

    [SerializeField] private Button replay;

    private void Start()
    {
        replay.onClick.AddListener(sceneswitch);
    }
    void sceneswitch()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
