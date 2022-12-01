using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public Text textname;
    public Text sentence;

    Queue<string> sentences = new Queue<string>();
    
    public void Begin(Dialogue info)
    {
        sentences.Clear();

        textname.text = info.name;

        foreach(var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }
        Next();
    }

    private void Next()
    {
        if(sentences.Count == 0)
        {
            End();
        }
        sentence.text = sentences.Dequeue();
    }

    private void End()
    {
        Debug.Log("a");
    }
}
