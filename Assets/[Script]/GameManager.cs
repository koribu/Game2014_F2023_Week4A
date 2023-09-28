using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;
    int _previousScore = 0;
    [SerializeField]
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

/*        if(_previousScore != score)
            UpdateScore();
        _previousScore = score;*/
    }

    public void ChangeSceneToGamePlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangeScore(int scoreIncrease)
    {
        score += scoreIncrease;
        UpdateScore();
    }

    void UpdateScore()
    {
        _scoreText.text = "Score: " + score;
    }
}
