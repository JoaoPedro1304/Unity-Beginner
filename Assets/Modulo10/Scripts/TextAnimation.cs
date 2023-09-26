using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] TMP_Text text;
void Start()
{

}

void Update()
{
    text.ForceMeshUpdate();

    TMP_TextInfo textInfo = text.textInfo;

    for(int i =0; i < textInfo.characterCount; i++)
    {
        TMP_CharacterInfo characterInfo = textInfo.characterInfo[i];
        
        if(characterInfo.isVisible){

            Vector3 [] verts = textInfo.meshInfo[characterInfo.materialReferenceIndex].vertices;
        
            for(int j = 0; j < 4; j++)
            {
                Vector3 currentPosition = verts[characterInfo.vertexIndex + j];
                verts[characterInfo.vertexIndex + j] = currentPosition + new Vector3(0,Mathf.Sin(Time.time*2 +currentPosition.x*0.01f)*15,0);
            }
        }
    }

    text.UpdateVertexData(TMP_VertexDataUpdateFlags.All);
}

}