using UnityEngine;

public class PlayerContactTriggerScript : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent FunctiontoCall;
    void OnTriggerEnter(Collider other)
    {
        if (other == null || other.CompareTag("Player")) FunctiontoCall.Invoke(); // other will equal null when this is called from an animation
    }
}