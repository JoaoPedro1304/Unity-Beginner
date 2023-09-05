using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Seletor : MonoBehaviour
{    
    [SerializeField] ListaPerguntas lista;
    [SerializeField] GameObject botoesRespostas;
    [SerializeField] GameObject fimDeJogo;
    [SerializeField] Text numeroDePerguntas;
    [SerializeField] Text perguntaTexto;
    [SerializeField] Text respostaCorreta;
    [SerializeField] Text respostaErrada1;
    [SerializeField] Text respostaErrada2;
    [SerializeField] Text respostaErrada3;
    [SerializeField] Text pontosText; 
    [SerializeField] Text recordText;
    [SerializeField] Text pularText;
    [SerializeField] Button pularButton;
    [SerializeField] Dropdown dificuldade;
    List<string> respostasPossiveis = new List<string>();
    List<Perguntas> listaAuxiliar = new List<Perguntas> ();
    int index, pontos, record, indexDificuldade;
    int contador =2;
     void Start()
    {
        
        Screen.SetResolution(1024,768,false);
        
        dificuldade.value = PlayerPrefs.GetInt("dificuldade",0);

        indexDificuldade = dificuldade.value;

        record = PlayerPrefs.GetInt("record",0); 

        recordText.text = "Record "+ record;

        pontosText.text = "Pontos "+ pontos;

        fimDeJogo.SetActive(false);

        listaAuxiliar = GetListaPerguntas();

        SetPerguntas(listaAuxiliar);
        
        pularText.text = "Pular "+contador;
                
    }
    
    public void SetDificuldade(){        
        if(indexDificuldade != dificuldade.value){
            indexDificuldade = dificuldade.value;
            PlayerPrefs.SetInt("dificuldade",indexDificuldade);
            pontos = 0;
            Start();                             
        }
        
    }
 
    List<Perguntas> GetListaPerguntas(){

        switch(indexDificuldade)
        {
            case 0:
                return lista.ListaDePerguntas;
            case 1:
                return lista.ListaDePerguntasMedium;
            case 2:
                return lista.ListaDePerguntasHard;
        }
        return lista.ListaDePerguntas;        
    }

    void SetPerguntas(List<Perguntas> lista){
        
        numeroDePerguntas.text ="Perguntas  " + lista.Count.ToString();
        
        index = Random.Range(0, lista.Count);

        respostasPossiveis.Add(lista[index].respostaCorreta);
        respostasPossiveis.Add(lista[index].respostaErrada1);
        respostasPossiveis.Add(lista[index].respostaErrada2);
        respostasPossiveis.Add(lista[index].respostaErrada3);

        perguntaTexto.text = lista[index].pergunta;
        
        int indexRespostas = Random.Range(0, respostasPossiveis.Count);

        respostaCorreta.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);

        respostaErrada1.text =respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);

        respostaErrada2.text =respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);

        respostaErrada3.text =respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
    }
    
    
    void Pontos(){
    switch(indexDificuldade){
        case 0:
            pontos +=10;
            break;
        case 1:
            pontos +=15;
            break;
        case 2:
            pontos+=20;
            break;
    }
        pontosText.text = "Pontos "+pontos;

        if(pontos > record){
            record = pontos;
            recordText.text = "Record "+record;

            PlayerPrefs.SetInt("record",record);
        }
    }

    public void RespostasOnClick(Text textoBotao){

        List<Perguntas>listaAuxiliar = GetListaPerguntas();

        if(textoBotao.text == listaAuxiliar[index].respostaCorreta){
            listaAuxiliar.Remove(listaAuxiliar[index]);

            numeroDePerguntas.text ="Perguntas  " + listaAuxiliar.Count.ToString();

            if(listaAuxiliar.Count == 0){
                Pontos();                
                fimDeJogo.SetActive(true);
                botoesRespostas.SetActive(false);
                
            }else{
                Pontos();                

                PlayerPrefs.SetInt("record",record);

                Start();
            }
        }else{

            ReloadScene();
        }        
    }
    
    public void Pular(){
        
        contador --;
        if(contador <= 0){
            contador =0;
            pularButton.enabled = false;
        }
        pularText.text = "Pular "+contador;
        
        listaAuxiliar.Remove(listaAuxiliar[index]);
                      
        numeroDePerguntas.text ="Perguntas  " + listaAuxiliar.Count.ToString();
        
        if(listaAuxiliar.Count == 0){
            fimDeJogo.SetActive(true);
            botoesRespostas.SetActive(false);
        }else{
            Start();   
        }

    }

    public void ReloadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResetRecord(){
        record = 0;
        recordText.text = "Record "+ record;
        PlayerPrefs.SetInt("record",record);
    }
   
}
