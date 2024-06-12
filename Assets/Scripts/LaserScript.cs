using UnityEngine;
public class LaserScript : MonoBehaviour {
    RaycastHit Hit;
    public GameObject Sparks;
    void Update() {
        bool hitTarget = (Physics.Raycast(transform.position, -this.transform.up, out Hit, Mathf.Infinity, 1));
        this.transform.localScale = new Vector3(1, hitTarget ? Hit.distance : 2000, 1);
        Sparks.transform.position = hitTarget ? Hit.point : new Vector3(0,-2000,0);
    }
}