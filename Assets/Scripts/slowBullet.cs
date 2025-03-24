using UnityEngine;

public class slowBullet : MonoBehaviour {
    public float speed = 5f;
    public float slowDown = 0.1f;
    
    public AudioSource audiosource;
    public AudioClip shot;
    public AudioClip hit;

    void Start() {
        audiosource = gameObject.AddComponent<AudioSource>();
        audiosource.PlayOneShot(shot);
        Destroy(gameObject, 5f);
    }

    void Update() {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            if (enemy != null) {
                enemy.Speed *= slowDown;
                audiosource.PlayOneShot(hit);
                Destroy(gameObject);
            }
        }
    }
}
