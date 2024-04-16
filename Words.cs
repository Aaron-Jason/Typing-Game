using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Words : MonoBehaviour
{
    public List<string> words;

    public TextMeshProUGUI text;
    public TMP_InputField input;

    public float extraTime = 5f;
    public void Update()
    {
        List();
        CompareText();
    }

    private void List()
    {
        text.text = words[0];
    }

   private void CompareText()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Timer timer = FindObjectOfType<Timer>();

            string inputText = input.text;
            string textMeshProText = text.text;

            if (inputText == textMeshProText)
            {
                words.RemoveAt(0);
                input.text = "";
                input.ActivateInputField();

                timer.AddTime(extraTime);
            }
            else
            {
                input.ActivateInputField();
            }
            if (words.Count == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

}

