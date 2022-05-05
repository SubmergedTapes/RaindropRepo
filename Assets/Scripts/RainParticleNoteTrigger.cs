using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainParticleNoteTrigger : MonoBehaviour
{
    ParticleSystem RainDrops;
    // Start is called before the first frame update
    void OnEnable()
    {
        RainDrops = GetComponent<ParticleSystem>();
        //Look at example code on the Unity manual triggers module that is bookmarked and continue from here!
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleTrigger()
    {
        Debug.Log("Collided");
        //FMODUnity.RuntimeManager.PlayOneShot("event:/TestEvent");
    }

}

