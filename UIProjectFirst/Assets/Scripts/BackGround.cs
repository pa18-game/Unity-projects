using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    public InputField Numbers;
    public int TotalNubmers;
    public GameObject MainScreen, LobbyScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnNumberEnter()
    {
       
        TotalNubmers = int.Parse(Numbers.text);
        print(TotalNubmers);
        MainScreen.SetActive(true);
        LobbyScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
