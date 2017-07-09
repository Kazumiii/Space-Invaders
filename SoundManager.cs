using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {


    public static SoundManager Instance = null;

    public AudioClip alienBuzz1= null;
    public AudioClip alienBuzz2 = null;
    public AudioClip alienDies = null;
    public AudioClip bulletFire = null;
    public AudioClip shipExplosiona = null;


    private AudioSource soundEffectAudio;

    // Use this for initialization
    void Start () {
	
        if(Instance==null)
        {
            Instance = this;
        }
        else if(Instance!=this)
        {
            Destroy(gameObject);
        }
        AudioSource source = GetComponent<AudioSource>();
        soundEffectAudio = source;
	}
	
	// Update is called once per frame
	
		
	public void PlayOneShot(AudioClip clip)
    {
        soundEffectAudio.PlayOneShot(clip);
    }
}
