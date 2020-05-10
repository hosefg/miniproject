using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArahController : MonoBehaviour
{

    public TextMeshProUGUI arahKiri;
    public TextMeshProUGUI arahKanan;
    public TextMeshProUGUI scorePlayerOne;
    public TextMeshProUGUI scorePlayerTwo;
    public TextMeshProUGUI timerCounter;
    public TextMeshProUGUI roundCounter;
    public TextMeshProUGUI statusKiri;
    public TextMeshProUGUI statusKanan;
    public AudioSource bgm;


    public int initialScoreKiri = 0;
    public int initialScoreKanan = 0;
    public string arah = null;
    public string arah1 = null;
    public string status= null;
    public bool getScore = false;

    // Start is called before the first frame update
    void Start()
    {
        scorePlayerOne.text = initialScoreKiri.ToString();
        scorePlayerTwo.text = initialScoreKanan.ToString();
    
    }

    // Update is called once per frame
    void Update()
    {

        if (int.Parse(roundCounter.text)%2==1){
            status = "Penebak";
            statusKiri.text = "Pemberi Arah";
            statusKanan.text = "Penebak";
        } else {
            status = "Pemberi Arah";
            statusKiri.text = "Penebak";
            statusKanan.text = "Pemberi Arah";
        }

         if(Input.GetKey(KeyCode.A)){
            arah = "Kiri";
            //arahKiri.text = arah;
        } else if(Input.GetKey(KeyCode.W)){
            arah = "Atas";
            //arahKiri.text = arah;
        } else if(Input.GetKey(KeyCode.D)){
            arah = "Kanan";
            //arahKiri.text = arah;
        } else if(Input.GetKey(KeyCode.S)){
            arah = "Bawah";
            //arahKiri.text = arah;
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            arah1 = "Kiri";
            //arahKiri.text = arah;
        } else if(Input.GetKey(KeyCode.UpArrow)){
            arah1 = "Atas";
            //arahKiri.text = arah;
        } else if(Input.GetKey(KeyCode.RightArrow)){
            arah1 = "Kanan";
            //arahKiri.text = arah;
        } else if(Input.GetKey(KeyCode.DownArrow)){
            arah1 = "Bawah";
            //arahKiri.text = arah;
        }
        
        if(timerCounter.text == "0"){
            arahKiri.text = arah;
            arahKanan.text = arah1;
            getScore = true;
        }

        if(arahKiri.text == arahKanan.text && status == "Penebak" && getScore){
            getScore = false;
            initialScoreKiri += 100;
            initialScoreKanan -= 50;
            if(initialScoreKiri < 0){
                initialScoreKiri = 0;
            } else if (initialScoreKanan < 0){
                initialScoreKanan = 0;
            }
            scorePlayerTwo.text = initialScoreKanan.ToString();
            scorePlayerOne.text = initialScoreKiri.ToString();
        } else if(arahKiri.text == arahKanan.text && status == "Pemberi Arah" && getScore){
            getScore = false;
            initialScoreKiri -= 50;
            initialScoreKanan += 100;
            if(initialScoreKiri < 0){
                initialScoreKiri = 0;
            } else if (initialScoreKanan < 0){
                initialScoreKanan = 0;
            }
            scorePlayerTwo.text = initialScoreKanan.ToString();
            scorePlayerOne.text = initialScoreKiri.ToString();
        } else if(arahKiri.text != arahKanan.text && status == "Pemberi Arah" && getScore){
            getScore = false;
            initialScoreKiri += 100;
            initialScoreKanan -= 50;
            if(initialScoreKiri < 0){
                initialScoreKiri = 0;
            } else if (initialScoreKanan < 0){
                initialScoreKanan = 0;
            }
            scorePlayerTwo.text = initialScoreKanan.ToString();
            scorePlayerOne.text = initialScoreKiri.ToString();
        } else if(arahKiri.text != arahKanan.text && status == "Penebak" && getScore){
            getScore = false;
            initialScoreKiri -= 50;
            initialScoreKanan += 100;
            if(initialScoreKiri < 0){
                initialScoreKiri = 0;
            } else if (initialScoreKanan < 0){
                initialScoreKanan = 0;
            }
            scorePlayerTwo.text = initialScoreKanan.ToString();
            scorePlayerOne.text = initialScoreKiri.ToString();
        }
    }
}
