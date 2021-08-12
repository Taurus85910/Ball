using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private int _sceneID;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneID);
    }
}
