using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStressManager : MonoBehaviour {
    public int playerMaxStress;
    public int playerCurrentStress; 
	// Use this for initialization
	void Start () {
        playerMaxStress = 100;
        playerCurrentStress = playerMaxStress;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
