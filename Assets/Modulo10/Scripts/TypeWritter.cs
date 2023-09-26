
using TMPro;

using UnityEngine;

public class TypeWritter : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] float characterCountDown;
    float timeCounter;
    int characterCounter;    
    void Start()
    {   
        timeCounter = Time.time;
        characterCounter =0;
    }

  
    void Update()
    {
        text.maxVisibleCharacters = characterCounter;

        TMP_TextInfo textInfo = text.textInfo;

        if(characterCounter < textInfo.characterCount){
            TMP_CharacterInfo characterInfo = textInfo.characterInfo[characterCounter];
            
            if (characterInfo.character == ' '){
                characterCounter++;
            }
        }

        if(Time.time > timeCounter + characterCountDown){
            timeCounter=Time.time;
            characterCounter++;
        }
                

        if(characterCounter > text.text.Length){
            this.enabled = false;
        }
    }

    
}
