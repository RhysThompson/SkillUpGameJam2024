using UnityEngine;
public class BallScript : MonoBehaviour {
    //public AudioClip collisionSound;
    int Colliding = 0;
    void Start() {
        this.GetComponent<Rigidbody>().maxAngularVelocity = 15;
    }
    void Update() {
        if (Colliding > 0) this.GetComponent<AudioSource>().volume = this.GetComponent<AudioSource>().pitch = this.GetComponent<Rigidbody>().angularVelocity.magnitude / 7;//Mathf.Clamp((this.GetComponent<Rigidbody>().angularVelocity.magnitude) / 3, 0.1f, 1f);
        else this.GetComponent<AudioSource>().pitch = this.GetComponent<AudioSource>().volume = 0;
    }
    void OnCollisionEnter(Collision other) {
        //print(other.impulse.magnitude);
        //if(other.impulse.magnitude > 3) this.GetComponent<AudioSource>().PlayOneShot(collisionSound, other.impulse.magnitude/10);
        Colliding++;
    }
    void OnCollisionExit(Collision other) {
        Colliding--;
    }
}