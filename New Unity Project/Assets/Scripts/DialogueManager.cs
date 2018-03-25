using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject DiaBox;
    public Text DiaText;

    public bool dialogActive;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            DiaBox.SetActive(false);
            dialogActive = false;
        }
    }

    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        DiaBox.SetActive(true);
        DiaText.text = dialogue;
    }

}
