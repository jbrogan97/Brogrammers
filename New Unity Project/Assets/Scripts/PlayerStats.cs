using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public int currentlevel;

    public int currentExp;

    public int[] toLevelUp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= toLevelUp[currentlevel])
        {
            currentlevel++;
        }
	}
}
