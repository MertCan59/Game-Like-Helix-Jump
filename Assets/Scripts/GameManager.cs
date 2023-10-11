using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float scoreMultiplier=1f;
    public float score = 0;
    public static GameManager instance { get; private set; }


    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    public void Start()
    {
        ResetLevel();
    }

    public void ResetLevel()
    {
        score = 0;
        LoadLevel();
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level1");
    }
    public void IncreaseScore()
    {
        score += 31*scoreMultiplier;
    }
}
