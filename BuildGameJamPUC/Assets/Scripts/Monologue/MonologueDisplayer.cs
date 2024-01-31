using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonologueDisplayer : MonoBehaviour
{
    public static MonologueDisplayer instance;
    [SerializeField] GameObject monologuePanel;
    [SerializeField] TMP_Text txt;
    [SerializeField] KeyCode exitKey = KeyCode.Space;
    [SerializeField] float typeDelay = 0.05f;
    private MonologueTrigger currentTrigger;
    public bool isPaused;

    private void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        if (monologuePanel.activeSelf)
        {
            if (Input.GetKeyDown(exitKey))
            {
                HideMonologue();
            }
        }
    }

    public void DisplayMonologue(Monologue m, MonologueTrigger t)
    {
        currentTrigger = t;
        StartCoroutine(DisplayText(m.text));
        monologuePanel.SetActive(true);
        isPaused = true;
    }

    private IEnumerator DisplayText(string text)
    {
        txt.text = "";
        foreach (char letter in text)
        {
            txt.text += letter;
            yield return new WaitForSeconds(typeDelay);
        }
    }

    public void HideMonologue()
    {
        txt.text = "";
        monologuePanel.SetActive(false);
        if(currentTrigger.onDismissEvent != null)
        {
            currentTrigger.onDismissEvent.Invoke();
        }
        currentTrigger = null;
        isPaused = false;
    }
}
