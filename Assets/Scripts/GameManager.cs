using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private Text timeGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        timeGame.text = ($"Время: {time.ToString()}");
    }
}
