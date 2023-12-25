using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject inventoryMenu;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitinMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SettingsButton()
    {
        settingsMenu.SetActive(true);
    }
    public void CloseSettingsButton()
    {
        settingsMenu.SetActive(false);
    }
    public void InventoryButton()
    {
        inventoryMenu.SetActive(true);
    }
    public void CloseInventoryButton()
    {
        inventoryMenu.SetActive(false);
    }
}
