using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CharacterDialogue : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player");
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Talk");
                ConversationManager.Instance.StartConversation(myConversation);
            }
        }
    }
}
