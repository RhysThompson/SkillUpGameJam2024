using UnityEngine;

public class FunctionsScript : MonoBehaviour
{
    public void ChangeScene(string sceneToLoad) // Load sceneToLoad or if that's blank reload current scene
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad != "" ? sceneToLoad : UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
