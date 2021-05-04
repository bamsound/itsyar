using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITSYUIManager : MonoBehaviour
{

    public GameObject menuButton;
    public GameObject subMenu;
    public GameObject subMenuOverlay;
    public GameObject instructions;

    public void Start()
    {
        subMenu.SetActive(false);
        subMenuOverlay.SetActive(false);
        instructions.SetActive(false);
    }

    public void ToggleSubMenu()
    {
        subMenu.SetActive(!subMenu.activeInHierarchy);
        subMenuOverlay.SetActive(!subMenuOverlay.activeInHierarchy);
    }

    public void ShowInstructions()
    {
        menuButton.SetActive(false);
        subMenuOverlay.SetActive(true);
        instructions.SetActive(true);
    }

    public void HideInstructions()
    {
        menuButton.SetActive(true);
        subMenuOverlay.SetActive(false);
        instructions.SetActive(false);
    }

    public void LearnMore()
    {
        Application.OpenURL("https://www.bekindmovement.co.uk/");
    }
}