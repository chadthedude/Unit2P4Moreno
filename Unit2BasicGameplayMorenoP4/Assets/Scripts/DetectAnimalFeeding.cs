using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAnimalFeeding : MonoBehaviour
{
    private static int score = 0;
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
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score++;
            Debug.Log("Score = " +  score);
        }
    }
}
