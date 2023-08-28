using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class CalcCedulas : MonoBehaviour
{
    //int[] array1 = new int[] { 1, 3, 5, 7, 9 };
    [Header("Inserir Valor")]
    public float valor;
    private int quantidade;
    private float [] valor_cedulas = new float [] {100.00f,50.00f,20.00f,10.00f,5.00f,2.00f,1.00f,0.50f,0.25f,0.10f,0.05f,0.01f};
    
    void Start()
    {
       //Definir valor no inspetor antes do play

       CalcularQuantidadeCedulas(valor);
             
    }
    
   
    void CalcularQuantidadeCedulas(float valor){        
        
        for (int i =0; i< valor_cedulas.Length; i++){
        
            if(valor_cedulas[i]<=valor){
                
                quantidade = (int)(valor/valor_cedulas[i]);

                if(valor<0.5){
                    
                    quantidade = (int)(Math.Round(valor,2)/valor_cedulas[i]);
                    
                }
                valor -= valor_cedulas[i]*quantidade;
               
                Debug.Log($"{quantidade} de {valor_cedulas[i]}");                

                if(valor < 0.00f){
                    break;
                }               
            }
                
        }         
    }
    
    }
