using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioClip musicClipThree;
    public RubyController RubyController;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayMusicClipThree();
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.loop = true;
        audioSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        if (RubyController.scoreValue >= 4)
        {
            PlayMusicClipOne();
        }
        if (RubyController.currentHealth <= 0)
        {
            PlayMusicClipTwo();
        }
    }
}
