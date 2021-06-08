using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip sound;
    public static bool sound_start = false;
    //public static bool sound_play = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (sound_start)
        {
            GetComponent<AudioSource>().clip = sound;
            GetComponent<AudioSource>().Play();
            Debug.Log("Sound Start");
            sound_start = false;
        }
        Debug.Log("Sound update");
    }
}
