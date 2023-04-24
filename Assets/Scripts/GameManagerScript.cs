using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class GameManagerScript : MonoBehaviour
{
    //NPCs Dialogue script
    public NPCConversation myConversation;
    //Saves percentage
    public float shapeShiftPercentage;


    // Update is called once per frame
    void Update()
    {
        //Gets the int from the Dialogue boxes
        shapeShiftPercentage = ConversationManager.Instance.GetInt("ShapeShiftPercentage");

        if(shapeShiftPercentage <= 5)
        {
            //Does smth :00000000
        }
    }
}
