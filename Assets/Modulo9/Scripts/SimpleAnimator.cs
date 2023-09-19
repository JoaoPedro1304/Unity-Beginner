using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SimpleAnimator : MonoBehaviour
{
    public Animator animator;
    public Slider slider;
    public AudioSource walkSound;    
    int count=0;
    float comboTime =1.5f;
    float clickTime = 0;        
    
    void Update()
    {        
        animator.SetFloat("speed", slider.value);
        
        if((Time.time - clickTime)>comboTime){
            count=0;       
            animator.SetBool("attack",false);
            animator.SetBool("attack1",false);
            animator.SetBool("attack2",false);
        }
        
               
    }

    public void Attack(){

        clickTime = Time.time;           
        count++;
        if(count == 1){
            animator.SetBool("attack", true);
        }else if( count == 2){
            animator.SetBool("attack",false);
            animator.SetBool("attack1", true);
        }else if( count == 3){
            animator.SetBool("attack",false);
            animator.SetBool("attack2", true);
        }
        
        if(count >=3){
            count =0;
        }

    }


    public void PlayVFX()
    {
       
    }
    public void PlayWalkSound(AudioClip clip){
        walkSound.clip = clip;
        walkSound.Play();
        
    }

}
