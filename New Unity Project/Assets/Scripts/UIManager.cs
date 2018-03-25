using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public Slider stressBar;
    public Slider friendsBar;
    public Text friendsText;
    public Text StressText;
    public PlayerStressManager playerStress;
    public FriendsManager playerFriends;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        stressBar.maxValue = playerStress.playerMaxStress;
        stressBar.value = playerStress.playerCurrentStress;
        friendsBar.value = playerFriends.playerCurrentFriends;
	}
}
