using UnityEngine;
public class LaserScript : MonoBehaviour
{
    RaycastHit Hit;
    public GameObject Sparks;
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, -this.transform.up, out Hit, Mathf.Infinity, 1))
        {
            this.transform.localScale = new Vector3(1, Hit.distance, 1);
            Sparks.transform.position = Hit.point;
        }
    }
}