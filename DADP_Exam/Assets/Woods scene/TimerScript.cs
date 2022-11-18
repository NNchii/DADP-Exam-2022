using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerScript : MonoBehaviour
{



   public float currentTime = 60f;
   public float StartingTime  = 60f;
    public TextMeshProUGUI Digit;
    public GameObject Fail;
    public GameObject win;
    public GameObject sprite;


    public ClickSpritescript bob;
    // Start is called before the first frame update
    void awake()
    {
        currentTime = 60f;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!bob.clicked && currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            Digit.text = currentTime.ToString("0");

        }
        else
        {
            sprite.SetActive(false);
            win.SetActive(true);
        }
        if (!bob.clicked && currentTime < 0)
        {
            win.SetActive(false);
            sprite.SetActive(false);
            Fail.SetActive(true);
        }

    }
}
