using UnityEngine;
using System.Collections;

public class EndGameController : MonoBehaviour {

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("End Game");
        }
    } 
}
