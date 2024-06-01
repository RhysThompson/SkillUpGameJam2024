using UnityEngine;

public class BallScript : MonoBehaviour
{
    public string sceneToLoad;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathBox")) UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        else if (other.CompareTag("Goal")) UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
        
    }
}
