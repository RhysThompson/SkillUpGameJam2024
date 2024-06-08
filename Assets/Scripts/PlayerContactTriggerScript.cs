using UnityEngine;

public class PlayerContactTriggerScript : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent FunctiontoCall;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) FunctiontoCall.Invoke();
    }
}