using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour
{
    public float speed = 4f;
    private Rigidbody rd;
    Vector3 move;
    public Text txt;
    public int score;
    private string tmpScore = "ScoreText";


    // Start is called before the first frame update
    void Start()
    {
        rd = this.gameObject.GetComponent<Rigidbody>();
        move = this.gameObject.transform.position;
        score = 0;
        txt = GameObject.Find("ScoreShow").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt(tmpScore, score);
    }
    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.gameObject.tag == "fish")
        {
            Destroy(o.gameObject);
            score += 1;
            txt.text = score.ToString();
        }
    }
}
