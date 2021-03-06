﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {
    public Text nameText;
    public Text dialogText;
    private Queue<string> sentences;
    public Animator animator;
    public Button robbe;
    public Button pinguin;
    

	// Use this for initialization
	void Start () {
        
        sentences = new Queue<string>();
        GameObject.Find("DialogManager").GetComponent<DialogTrigger>().TriggerDialog();

    }

    public void StartDialog(Dialog dialog)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialog.name;
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 2)
        {
            EndDialog();
            robbe.enabled = true;
            return;
        }

        if (sentences.Count == 0)
        {
            EndDialog();
            pinguin.enabled = true;
            GameObject.Find("DisableHover").SetActive(false);
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    public void DisplayNextSentence2()
    {
        animator.SetBool("IsOpen", true);
        if (sentences.Count == 0)
        {
            EndDialog();
            pinguin.enabled = true;
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    void EndDialog()
    {
        animator.SetBool("IsOpen", false);
    }
	
}
