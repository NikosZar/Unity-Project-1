using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextAlignment dialogueText;
    public string dialogue;
    public bool dialogueActive;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player interacted with GameObject");

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Player is no longer interacting with GameObject");
    }

}
