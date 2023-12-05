using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{   
    [SerializeField] private Animator laserAnimator;
    [SerializeField] private AudioClip laserSFX;

    private AudioSource laserAudioSource;
    private void Awake()
    {   
        laserAudioSource = GetComponent<AudioSource>();
    }
    public void LaserGunFired()
    {
        laserAnimator.SetTrigger("Fire");
        laserAudioSource.PlayOneShot(laserSFX);
    }
}
