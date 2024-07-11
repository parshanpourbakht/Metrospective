using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public static GameTimer Instance { get; private set; }
    public float maxPlayTime = 420.0f; // 7 minutes in seconds
    private float elapsedTime = 0.0f;
    private bool isGameOver = false;

    private void Awake()
    {
        // Singleton pattern implementation
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (isGameOver) return;

        elapsedTime += Time.deltaTime;

        // Check if the timer is done
        if (elapsedTime >= maxPlayTime)
        {
            // Check if the current scene is a video scene (index 7 to 12)
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            if (currentSceneIndex >= 7 && currentSceneIndex <= 12)
            {
                // Call SetPreviousScene on the SceneManager game object with end scene index 13
                GameObject sceneManager = GameObject.Find("SceneManager"); // Adjust the name if necessary
                if (sceneManager != null)
                {
                    isGameOver = true;
                    Destroy(gameObject);
                    sceneManager.GetComponent<SceneTransition>().SetPreviousScene(13);
                }
            }
            else
            {
                // End game if not in a video scene
                EndGame();
            }
        }
    }

    private void EndGame()
    {
        isGameOver = true;
        Destroy(gameObject);
        SceneManager.LoadScene(13); // Load end screen
    }
}