using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

    private void Start() {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
            StartCoroutine("WaitForTime");
    }

    IEnumerator WaitForTime() {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
