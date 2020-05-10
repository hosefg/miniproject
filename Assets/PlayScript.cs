using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayScript : MonoBehaviour
{
    public AudioSource bgm;
    // Start is called before the first frame update
    public void Mulai(){
        SceneManager.LoadScene("SampleScene");
    }
}