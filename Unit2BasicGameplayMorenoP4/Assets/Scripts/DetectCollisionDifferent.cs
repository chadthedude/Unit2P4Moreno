using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionDifferent : MonoBehaviour
{
    public int playerHealth = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            if (playerHealth > 0)
            {
                HealthDecrementer();
            }
            else
            {
                Destroy(gameObject);
                Debug.Log("GameOver!!!");
            }
        }
    }

    void HealthDecrementer()
    {
        playerHealth = playerHealth - 1;
        Debug.Log("LOL");
        Debug.Log("Health =" +  playerHealth);
    }
}
