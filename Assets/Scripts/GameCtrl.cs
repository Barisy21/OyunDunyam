using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameCtrl : MonoBehaviour
{
    public Button[] buttons;
    public Button skipbutton;
    private int randomIndex = 0;

    private List<Button> buttonlist;

    private void Start()
    {
        buttonlist = new List<Button>(buttons);
        randomIndex = Random.Range(0, buttonlist.Count);

        buttonlist[randomIndex].gameObject.SetActive(true);
    }

    private void Update()
    {

    }

    public void skip()     
    {
        if(buttonlist.Count > 1)
        {
            buttonlist[randomIndex].gameObject.SetActive(false);
            buttonlist.RemoveAt(randomIndex);
            randomIndex = Random.Range(0, buttonlist.Count);
            buttonlist[randomIndex].gameObject.SetActive(true);
        }
    }

}
