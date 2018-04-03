using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public int currentlevel;

    public int currentExp;

    private int[] toLevelUp = new int[] { 0, 20, 50, 100, 250, 500, 1000, 1750, 2750, 4000 };

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
