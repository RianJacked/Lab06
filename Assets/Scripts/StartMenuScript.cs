using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(ChangeLevel());
        Application.LoadLevel("SampleScene");
    }
    
    public void ExitGame(){
        Application.Quit();
    }

    IEnumerator ChangeLevel(){
        FaderScript fader = GameObject.Find("Fader").GetComponent<FaderScript>();
        float result = fader.BeginFade(1);
        yield return new WaitForSeconds(2);
    }
}
