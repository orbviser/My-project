using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int diceRoll = 7;
    // Start is called before the first frame update
    void Start()
    {
        switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Medicore damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completly missed and fell on your face.");
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}