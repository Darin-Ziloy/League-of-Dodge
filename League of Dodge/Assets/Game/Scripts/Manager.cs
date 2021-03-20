using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    #region Singleton

    public static Manager manager;

    private void Awake()
    {
        manager = this;
    }

    #endregion


    public Text score;
    public GameObject EnemyTarget;
    

    
}
