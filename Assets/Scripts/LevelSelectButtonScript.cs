using UnityEngine;

public class LevelSelectButtonScript : MonoBehaviour
{
    public string sceneToLoad;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }
}
