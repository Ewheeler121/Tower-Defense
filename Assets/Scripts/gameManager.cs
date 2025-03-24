using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {
    public AudioClip music;
    public AudioSource audioSource;
    public EnemyGenerator generator;
    public bool menuOpen = false;

    public float countdown = 60f;
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.loop = true;
        audioSource. playOnAwake = false;
        audioSource.volume = 0.5f;
        audioSource.Play();

    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f) {
            generator.secondsBetweenEnemies -= 0.2f;
            if(generator.secondsBetweenEnemies <= 0.1f) {
                SceneManager.LoadScene("Victory");
            }
            countdown = 30f;
        }
    }
}
