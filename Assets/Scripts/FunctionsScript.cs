using UnityEngine;

public class FunctionsScript : MonoBehaviour
{
    public string SceneToLoad;
    public void ChangeScene(string sceneToLoad) // Load sceneToLoad or if that's blank reload current scene
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad != "" ? sceneToLoad : (SceneToLoad != "" ? SceneToLoad : UnityEngine.SceneManagement.SceneManager.GetActiveScene().name));
    }

    public void FadeScene(string sceneToLoad)
    {
        GameObject.FindGameObjectWithTag("Fade").GetComponent<FunctionsScript>().SceneToLoad = sceneToLoad;
        GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>().Play("FadeOnAnim");
    }

    public void SaveSceneCompletion()
    {
        PlayerPrefs.SetInt(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name, 1);
    }
}
