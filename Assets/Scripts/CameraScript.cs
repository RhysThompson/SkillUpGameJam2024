using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3 Offset;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Offset = this.transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void Update()
    {
        this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + Offset;
    }
}
