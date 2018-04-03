using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public Slider stressBar;
    public Slider friendsBar;
    public Slider moneyBar;
    public Text StressText;
    public Text friendsText;
    public Text moneyText;
    public MoneyManager playerMoney;
    public PlayerStressManager playerStress;
    public FriendsManager playerFriends;
    public PlayerStats thePS;
    public Text levelText;

    private static bool UIExists;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        stressBar.maxValue = playerStress.playerMaxStress;
        stressBar.value = playerStress.playerCurrentStress;
        friendsBar.value = playerFriends.playerCurrentFriends;
        moneyBar.value = playerMoney.playerCurrentMoney;
        StressText.text = "Happiness: " + playerStress.playerCurrentStress + "/" + playerStress.playerMaxStress;
        friendsText.text = "Friends: " + playerFriends.playerCurrentFriends + "/" + playerFriends.playerMaxFriends;
        moneyText.text = "Money: " + playerMoney.playerCurrentMoney + "/" + playerMoney.playerMaxMoney;
        levelText.text = " Lvl: " + thePS.currentlevel;
	}
}
