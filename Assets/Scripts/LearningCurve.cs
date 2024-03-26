using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int diceRoll = 7;
    // Start is called before the first frame update
    void Start()
    {
        //Massive
        int[] topPlayersScores = { 713, 549, 984 };
        topPlayersScores[1] = 1001;
        Debug.Log(topPlayersScores[1]);

        //List
        List<string> questPartyMembers = new List<string>()
        { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
        //Add to the end of the list 
        questPartyMembers.Add("Craven the Necromancer");
        //Add to the position 2
        questPartyMembers.Insert(1, "Tanis the Thief");
        //Remove 1st item
        questPartyMembers.RemoveAt(0);
        //Remove item "Grim the Barbarian"
        questPartyMembers.Remove("Grim the Barbarian");

        //Dictionarry
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 6},
            {"Sword", 1},
            {"Helmet", 1}
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);
        //Update count of potions
        itemInventory["Potin"] = 10;
        //Add new item
        itemInventory.Add("Throwing Knife", 3);
        //Add new item
        itemInventory["Bandage"] = 5;
        //Update count of Aspirin if it exist
        if (itemInventory.ContainsKey("Aspirin"))
        {
            itemInventory["Aspirin"] = 3;
        }
        //Remove helmet from inventory
        itemInventory.Remove("Helmet");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}