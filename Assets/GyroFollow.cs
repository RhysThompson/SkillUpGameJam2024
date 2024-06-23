
using UnityEngine;

public class GyroFollow : MonoBehaviour
{
   [Header("Tweaks")]
   [SerializeField] private Quaternion baseRotation = new Quaternion(0,0,1,0);

   private void Start()
    {
        GyroscopeInputScript.Instance.EnableGyro();
    }

    private void Update()
    {
        transform.localRotation = GyroscopeInputScript.Instance.GetGyroRotation() * baseRotation;
    }
}
