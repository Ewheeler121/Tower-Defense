using UnityEngine;

public class basicBullet : MonoBehaviour {
    public float speed = 5f;
      
    public AudioSource audiosource;
    public AudioClip shot;
    public AudioClip hit;
    public AudioClip explode;

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
            if(enemy != null) {
                enemy.Heath -= 1;
                if(enemy.Heath <= 0) {
                    audiosource.PlayOneShot(explode);
                    Destroy(other.gameObject);
                } else {
                    audiosource.PlayOneShot(hit);
                }
                Destroy(gameObject);
            }
        }
    }
}
