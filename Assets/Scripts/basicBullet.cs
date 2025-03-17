using UnityEngine;

public class basicBullet : MonoBehaviour {
    public float speed = 5f;
      
    void Start() {
        Destroy(gameObject, 5f);
    }

    void Update() {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Destroy(other.gameObject);
        }
    }
}
