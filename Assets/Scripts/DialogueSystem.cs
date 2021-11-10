using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public Text dialogueText;
    public string dialogue;
    public bool PlayerInRange;

    private void Update()
    {
        if (Input.GetKey (KeyCode.F) && PlayerInRange)
        {
            dialogueText.text = dialogue;
        }
        else if (PlayerInRange == false)
        {
            dialogueText.text = "";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player interacted with GameObject");
            PlayerInRange = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Player is no longer interacting with GameObject");
        PlayerInRange = false;
    }

}
