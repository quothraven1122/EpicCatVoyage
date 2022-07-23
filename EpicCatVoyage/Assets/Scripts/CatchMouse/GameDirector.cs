using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject timerText;
    GameObject pointText;
    float time = 30.0f;
    int point = 0;

    public void GetMouse()
    {
        this.point += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = "00 : "+this.time.ToString("F0");
        this.pointText.GetComponent<Text>().text = "���� �� : " + this.point.ToString() + " ����";
    }
}