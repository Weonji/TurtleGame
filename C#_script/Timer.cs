using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float maxTime = 5f;
    float timeLeft;
    Image timerBar;
    void Start()
    {
        
        timerBar = GetComponent<Image>();
        timeLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft < maxTime)
        {
            timeLeft += Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            SceneManager.LoadScene("Ending");
            Time.timeScale = 0;
        }
    }
}
