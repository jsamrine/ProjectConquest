using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

    public string controllingPlayer;
    public int armies;
    public string planetName;
    public Planet[] connections; //Test variable until map is created

    public Text planetNameTxt;
    public Text armiesDisplay;
	// Use this for initialization
	void Start () {
        connections = new Planet[10];
        armiesDisplay.text = "Armies " + armies.ToString();
        armiesDisplay.transform.position = gameObject.transform.position + new Vector3(0, 1.5f, 0);
        planetNameTxt.text = planetName;
        planetNameTxt.transform.position = gameObject.transform.position - new Vector3(0, 1.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
