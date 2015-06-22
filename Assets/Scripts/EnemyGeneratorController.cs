using UnityEngine;
using System.Collections;

public class EnemyGeneratorController : MonoBehaviour {

    public Transform prefab;
    bool collided;
    public int numberOfClones;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (collided)
        {
            collided = false;
            for (int i = 0; i < numberOfClones; i++)
            {
                Instantiate(prefab, new Vector3(
                    gameObject.transform.position.x + 20,
                    gameObject.transform.position.y,
                    gameObject.transform.position.z),
                    Quaternion.Inverse(Quaternion.identity));
            }
            
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            collided = true;
        }
    }
}
