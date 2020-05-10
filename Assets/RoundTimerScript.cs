using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoundTimerScript : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public TextMeshProUGUI round;
    public int counter = 5;
    public int roundNumber = 1;
    public bool roundCont = false;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = counter.ToString();
        StartCoroutine(hitungMundur());
    }

    // Update is called once per frame
    void Update()
    {
        if(roundCont){
            timer.text = counter.ToString();
            StartCoroutine(hitungMundur());
            roundCont = false;
        }
    }

    IEnumerator hitungMundur()
    {
        while(counter > 0){
        yield return new WaitForSeconds(1);
        counter -= 1;
        timer.text = counter.ToString();
        }
        roundNumber += 1;
        if(roundNumber<12){
            roundCont = true;
            counter = 5;
            round.text = roundNumber.ToString();
        } else {
            timer.text = "OVR";
        }
    }
}
