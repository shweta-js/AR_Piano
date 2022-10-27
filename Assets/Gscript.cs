using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Gscript : MonoBehaviour
{
    
    public GameObject cube;
    public VirtualButtonBehaviour Vb;
    public AudioClip MusicClip;
    public AudioSource MusicSource;



    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        
       cube.SetActive(false);
        MusicSource.clip=MusicClip;


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
       cube.SetActive(true);
        MusicSource.Play();
     
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb){
        cube.SetActive(false);
    }
}
