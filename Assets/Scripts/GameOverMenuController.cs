using UnityEngine;
using System.Collections;

public class GameOverMenuController : MonoBehaviour {

    public void OnClickRestart()
    {
        Application.LoadLevel("Level 1");
    }

    public void OnClickMainMenu()
    {
        Application.LoadLevel("Main Menu");
    }
}
