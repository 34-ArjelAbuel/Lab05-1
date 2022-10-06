using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.instance.CheckWinCondition();
        GameManager.instance.Timer();
        GameManager.instance.TimeLose();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            GameManager.instance.AddCoin();
            Destroy(other.gameObject);
        }
        if (other.gameObject.layer == 4)
        {
            GameManager.instance.LoseGame();
        }
    }
}
