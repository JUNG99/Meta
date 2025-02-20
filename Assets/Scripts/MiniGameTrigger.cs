using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGameTrigger : MonoBehaviour
{

    public GameObject uiPanel;
    public Button startButton;
    public Button cancelButton;
    public string minigameScene = "Plane";


    private void Start()
    {
        uiPanel.SetActive(false);
        startButton.onClick.AddListener(StartMiniGame);
        cancelButton.onClick.AddListener(CloseUI);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(true);
        }
    }

    void StartMiniGame()
    {
        SceneManager.LoadScene(minigameScene);
    }

    void CloseUI()
    {
        uiPanel.SetActive(false);
    }
}
