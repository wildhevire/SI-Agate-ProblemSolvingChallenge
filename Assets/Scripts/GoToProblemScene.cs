using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToProblemScene : MonoBehaviour
{
    public int problem;
    private Button button;
    private Text text;
    void Start()
    {
        button = GetComponent<Button>();
        text = GetComponentInChildren<Text>();
        text.text = "Problem " + problem;
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(problem);
        });
    }

    
}
