using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public Text woodDisp;
    public Text stoneDisp;
    public Text metalDisp;

    public float woodTotal = 0;
    public float stoneTotal = 0;
    public float metalTotal = 0;

    public float woodClick = 1;
    public float stoneClick = 1;
    public float metalClick = 1;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        woodDisp.text = woodTotal.ToString();
        stoneDisp.text = stoneTotal.ToString();
        metalDisp.text = metalTotal.ToString();
   
	}
}
