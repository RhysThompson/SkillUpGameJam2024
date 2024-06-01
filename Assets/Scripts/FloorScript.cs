using UnityEngine;

public class FloorScript : MonoBehaviour
{
    public GameObject LevelParent;
    void FixedUpdate()
    {
        Vector3 rot = new Vector3(this.transform.rotation.eulerAngles.x < 150 ? Mathf.Clamp(this.transform.rotation.eulerAngles.x, -30, 30) : Mathf.Clamp(this.transform.rotation.eulerAngles.x, 360-30, 360+30), 0, this.transform.rotation.eulerAngles.z < 150 ? Mathf.Clamp(this.transform.rotation.eulerAngles.z, -30, 30) : Mathf.Clamp(this.transform.rotation.eulerAngles.z, 360 - 30, 360 + 30));
        this.transform.rotation = Quaternion.Euler(Vector3.zero);
        LevelParent.transform.parent = null;

        this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;

        LevelParent.transform.parent = this.transform;
        this.transform.eulerAngles = rot;

        this.transform.Rotate(new Vector3(Mathf.Clamp(Input.GetAxisRaw("Mouse Y") + Input.GetAxis("Vertical"), -1,1), 0, -Mathf.Clamp(Input.GetAxisRaw("Mouse X") + Input.GetAxis("Horizontal"), -1, 1)));
        if(Input.GetKey(KeyCode.Escape)) UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
