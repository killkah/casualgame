using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject loseMenu;
    [SerializeField] private Text timeText;
    [SerializeField] private Text loseText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            loseMenu.SetActive(true);
            Destroy(player);
            loseText.text = timeText.text;
        }
    }
}
