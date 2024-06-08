using UnityEngine;
public class CameraScript : MonoBehaviour
{
    public Vector3 Offset = new Vector3(0, 0, 0);
    void Update()
    {
        if(Offset == Vector3.zero) Offset = this.transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
        this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + Offset;
    }
}