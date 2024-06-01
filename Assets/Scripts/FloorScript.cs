using UnityEngine;

public class FloorScript : MonoBehaviour
{
    void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(Mathf.Clamp(Input.GetAxisRaw("Mouse Y"),-1,1), 0, -Mathf.Clamp(Input.GetAxisRaw("Mouse X"), -1, 1)));
        if(Input.GetKey(KeyCode.Escape)) UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
