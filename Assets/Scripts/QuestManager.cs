using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public bool deliveredPapers;
    public bool firstTalkPrincipal;

    public void OnPapersDelivered()
    {
        deliveredPapers = true;
    }

    public void FirstTalkPrincipal()
    {
        firstTalkPrincipal = true;
    }
    
}
