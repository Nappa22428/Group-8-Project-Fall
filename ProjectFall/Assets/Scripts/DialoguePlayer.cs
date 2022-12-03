using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialoguePlayer : MonoBehaviour
{
    public string conversationStartNode;
    private DialogueRunner dialogueRunner;

    // Start is called before the first frame update
    void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            dialogueRunner.StartDialogue(conversationStartNode);
        }
    }
}
