using UnityEngine;
public class FloorScript : MonoBehaviour
{
    public GameObject LevelParent;
    public int AxisLock = 0; // 0 = both, 1 = vertical, 2 = horizontal, 4 = disabled
    void FixedUpdate()
    {
        Vector3 rot = new Vector3(this.transform.rotation.eulerAngles.x < 150 ? Mathf.Clamp(this.transform.rotation.eulerAngles.x * 0.95f, -35, 35) : Mathf.Clamp(((this.transform.rotation.eulerAngles.x -360) * 0.95f)+360, 360-35, 360+35), 0, this.transform.rotation.eulerAngles.z < 150 ? Mathf.Clamp(this.transform.rotation.eulerAngles.z * 0.95f, -35, 35) : Mathf.Clamp(((this.transform.rotation.eulerAngles.z - 360) * 0.95f) + 360, 360 - 35, 360 + 35));
        this.transform.rotation = Quaternion.Euler(Vector3.zero);
        LevelParent.transform.parent = null;
        this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        LevelParent.transform.parent = this.transform;
        this.transform.eulerAngles = rot;

        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().AddForce(new Vector3(Mathf.Clamp(/*Input.GetAxisRaw("Mouse Y") + */AxisLock != 1 ? Input.GetAxis("Horizontal") : 0, -1, 1), 0, -Mathf.Clamp(/*Input.GetAxisRaw("Mouse X") + */AxisLock != 2 ? -Input.GetAxis("Vertical") : 0, -1, 1))/15, ForceMode.Impulse);
        if (AxisLock != 4) this.transform.Rotate(new Vector3(Mathf.Clamp(/*Input.GetAxisRaw("Mouse Y") + */AxisLock != 2 ? Input.GetAxis("Vertical") : 0, -1,1), 0, -Mathf.Clamp(/*Input.GetAxisRaw("Mouse X") + */AxisLock != 1 ? Input.GetAxis("Horizontal") : 0, -1, 1)));
        if (Input.GetKey(KeyCode.Escape))
        {
            GameObject.FindGameObjectWithTag("Fade").GetComponent<FunctionsScript>().SceneToLoad = "MainMenu";
            GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>().Play("FadeOnAnim");
        }
    }
}