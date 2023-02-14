using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;
    [SerializeField]
    private AudioSource ropeStretchFX, hookGrab_Fish_FX, hookGrab_Minus_FX, Boat_FX, Win_FX, Lost_FX ;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Boat()
    {
        Boat_FX.Play();
    }

    public void HookGrab_Fish()
    {
        hookGrab_Fish_FX.Play();
    }

    public void HookGrab_Minus()
    {
        hookGrab_Minus_FX.Play();
    }

    public void Win()
    {
        Win_FX.Play();
    }
    
    public void Lost()
    {
        Lost_FX.Play();
    }

    public void RopeStretch(bool playFX)
    {
        if (playFX)
        {
            if (!ropeStretchFX.isPlaying)
            {
                ropeStretchFX.Play();
            }
        }
        else
        {
            if (ropeStretchFX.isPlaying)
            {
                ropeStretchFX.Stop();
            }
        }
    }


    public void Boat(bool playFX)
    {
        if (playFX)
        {
            if (Boat_FX.isPlaying)
            {
                Boat_FX.Play();
            }
        }
        else
        {
            if (!Boat_FX.isPlaying)
            {
                Boat_FX.Stop();
            }
        }
    }
}
