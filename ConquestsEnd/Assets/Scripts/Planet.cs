using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

    public string controllingPlayer;
    public int armies;
    public Planet[] connections; //Test variable until map is created

    public Text planetName;
    public Text armiesDisplay;
	// Use this for initialization
	void Start () {
        connections = new Planet[10];
        armiesDisplay.text = armies.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
