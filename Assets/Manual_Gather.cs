using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Manual_Gather : MonoBehaviour {

    public GameManager GM;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // add wood when clicking on the Gather Wood button
    public void woodClicked()
    {
        GM.woodTotal += GM.woodClick;
    }
    
    // add stone when clicking on the Gather Stone button
    public void stoneClicked()
    {
        GM.stoneTotal += GM.stoneClick;
    }

    // add metal when clicking on the Gather Metal button
    public void metalClicked()
    {
        GM.metalTotal += GM.metalClick;
    }
}
