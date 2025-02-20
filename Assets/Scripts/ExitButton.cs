using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Button loadSceneButton;  
    public string sceneName = "SampleScene"; 

    void Start()
    {
        loadSceneButton.onClick.AddListener(LoadNewScene);
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}