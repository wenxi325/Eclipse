using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Adapted from "Electric Door Sound Effect HD:
 * https://www.youtube.com/watch?v=LxzBlorJ8ec
 *
 * Audio assets from: https://www.bensound.com
 */
public class SoundManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Click;
    public static SoundManager sfxInstance;

    private void Awake()
    {
        if(sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
