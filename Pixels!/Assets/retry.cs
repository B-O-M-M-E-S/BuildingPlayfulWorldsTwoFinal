﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
   public void Hoppa(){
       SceneManager.LoadScene("Level1");
   }
}
