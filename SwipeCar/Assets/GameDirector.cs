using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject car;
    GameObject flag;
    GameObject distance;

	// Use this for initialization
	void Start () {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
	}
	
	// Update is called once per frame
	void Update () {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        float over = 0;

        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "旗まで" + length.ToString("F2") + "m";
        }
        else if (length >= -1.5f)
        {
            over = length * -1;
            this.distance.GetComponent<Text>().text = over.ToString("F2") + "m" + "超過";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "あああああああああああああああああああああ";
        }
	}
}
