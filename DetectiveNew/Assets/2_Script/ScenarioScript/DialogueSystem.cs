using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance;

    public ELEMENTS elements;
     void Awake()
    {

        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void Say(string speech, string speaker = "")
    {
        StopSpeaking();
        

       speaking= StartCoroutine(Speaking(speech,false,speaker));
    }
    public void SayAdd(string speech, string speaker = "")
    {
        StopSpeaking();
        speechText.text = targetSpeech;

        speaking = StartCoroutine(Speaking(speech, true, speaker));
    }
    public void StopSpeaking()
    {
        if (isSpeaking)
        {

        StopCoroutine(speaking);
        }
        speaking = null;
    }
    public bool isSpeaking { get{ return speaking != null; } }
    [HideInInspector]public bool isWaitingForUserInput = false;

    string targetSpeech = "";
    
    Coroutine speaking = null;
    IEnumerator Speaking(string speech,bool additive,string speaker = "")
    {
        speechPanel.SetActive(true);
        targetSpeech = speech;

        if (!additive)
            speechText.text = "";
        else
            targetSpeech = speechText.text + targetSpeech;

        speakerNameText.text = DetermineSpeaker(speaker);
        isWaitingForUserInput = false;

        while(speechText.text != targetSpeech)
        {
            speechText.text += targetSpeech[speechText.text.Length];
            yield return new WaitForEndOfFrame();
        }
       
        //text finished
        isWaitingForUserInput = true;
        while (isWaitingForUserInput)
            yield return new WaitForEndOfFrame();
        
        StopSpeaking();
    }
    string DetermineSpeaker(string s)
    {
        string retVal = speakerNameText.text;//default return is the current name
        if(s != speakerNameText.text && s !="")
        
            retVal = (s.ToLower().Contains("narrator")) ? "" : s;
            
        return retVal;
        
    }

    public void Close()
    {
        StopSpeaking();
        speechPanel.SetActive(false);
    }

        [System.Serializable]
        public class ELEMENTS
    {
        //<summary>
        //main panel containing all dialogue related on UI
        //</summary>


        public GameObject speechPanel;
        public Text speechText;
        public Text speakerNameText;
    }
    public GameObject speechPanel { get { return elements.speechPanel; } }
    public Text speechText { get { return elements.speechText; } }
    public Text speakerNameText { get { return elements.speakerNameText; } }
}
