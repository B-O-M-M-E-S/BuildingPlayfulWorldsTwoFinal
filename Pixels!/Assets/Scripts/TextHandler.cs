﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextHandler : MonoBehaviour
{
   public TextMeshProUGUI textDisplay;
   public string[] sentences;
   private int index;
   public float typingSpeed;

   void Start(){

       StartCoroutine(Type());
   }

   IEnumerator Type(){

       foreach(char letter in sentences[index].ToCharArray()){
           textDisplay.text += letter;
           yield return new WaitForSeconds(typingSpeed);
       }
   }

   public void Nextsentence(){

       if(index < sentences.Length - 1){
           index++;
           textDisplay.text = "";
           StartCoroutine(Type());
       } else {
           textDisplay.text = "";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }

   }

}
