using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeInputScript : MonoBehaviour
{
    #region Instance
    private static GyroscopeInputScript instance;
    public static GyroscopeInputScript Instance;
    {
        get 
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GyroscopeInputScript>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned GyroscopeInputScript", typeof(GyroscopeInputScript)).GetComponent<GyroscopeInputScript?();
                }
            }

            return instance;
        }
 
    }
    #endregion
    
    [Header("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;

    public void EnableGyro()
    {
        // Already active ated 
        if (gyroActive)
            return;
        
        if (SystemInfo.supportsGryoscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }
        else
        {
            Debug.Log("Gyro is not supported on this device")
        }
    }
    private void Update()
    {
        if (gyroActive)
        {
            rotation = gyro.attitude;
        }
    }
    public Quaternion GetGyroRotation()
    {
        return rotation;
    }
}
