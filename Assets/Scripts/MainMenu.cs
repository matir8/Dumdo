using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public void OnClickPlay()
    {
        Application.LoadLevel("Level 1");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
