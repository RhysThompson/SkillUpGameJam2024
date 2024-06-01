using UnityEngine;

public class LevelSelectButtonScript : MonoBehaviour
{
    public string sceneToLoad;

    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }
}
