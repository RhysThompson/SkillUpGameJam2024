using UnityEngine;
public class ScenePersistScript : MonoBehaviour {
    void Awake() {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("BackgroundMusic")) if(obj != this.gameObject) Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}