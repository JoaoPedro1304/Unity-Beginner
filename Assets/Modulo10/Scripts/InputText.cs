
using UnityEngine;
using TMPro;

using System;
using UnityEngine.UIElements;

public class InputText : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] TMP_InputField inputText;

    int index;

    void Start()
    {
        
    }

   
    void Update()
    {
        
        text.ForceMeshUpdate();
        
        try
        {
            if(text.text.Contains(inputText.text)){

                index = text.text.IndexOf(inputText.text);

                for(int i = index; i < inputText.text.Length + index; i++){

                    //Debug.Log(inputText.text.Length);
                    //Debug.Log(""+ text.textInfo.characterInfo[i].character);
                    
                    TMP_CharacterInfo characterInfo = text.textInfo.characterInfo[i];
                    if(characterInfo.character == ' '){

                    }else{

                        Vector3 [] verts = text.textInfo.meshInfo[characterInfo.materialReferenceIndex].vertices;
                        for(int j = 0; j < 4; j++)
                        {
                            Vector3 currentPosition = verts[characterInfo.vertexIndex + j];
                            verts[characterInfo.vertexIndex + j] = currentPosition + new Vector3(Mathf.Sin(Time.time*5 + currentPosition.x*0.01f)*3, Mathf.Sin(Time.time*2 + currentPosition.x*0.01f)*15,0);
                        }
                    }
                }                 

                    
            }         
            
        }catch(System.IndexOutOfRangeException index){
            Debug.Log(index);            
        }    
        
         text.UpdateVertexData(TMP_VertexDataUpdateFlags.All);

    }


public void Search(){
        
   //string textString = text.text;
   //string inputString = inputText.text;
//    int indexString;

  
//     Debug.Log(text.text+"\n "+ inputText.text);
    
//     Debug.Log(text.text.Contains(inputText.text));    

//     Debug.Log(text.text.IndexOf(inputText.text));

//     indexString = text.text.IndexOf(inputText.text);
    

    if(text.text.Contains(inputText.text)){

                index = text.text.IndexOf(inputText.text);

                for(int i = index; i < inputText.text.Length + index; i++){
                    
                    Debug.Log(""+ text.textInfo.characterInfo[i].character);                    
                    
                                  
                //     TMP_CharacterInfo characterInfo = text.textInfo.characterInfo[i];

                //     Vector3 [] verts = text.textInfo.meshInfo[characterInfo.materialReferenceIndex].vertices;

                //     for(int j = 0; j < 4; j++)
                //     {
                //         Vector3 currentPosition = verts[characterInfo.vertexIndex + j];
                //         verts[characterInfo.vertexIndex + j] = currentPosition + new Vector3(0,Mathf.Sin(Time.time*2 + currentPosition.x*0.01f)*40,0);
                //     }
                // }
            }    
    }
   
}

}
