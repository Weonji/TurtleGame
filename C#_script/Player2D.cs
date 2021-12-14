using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
{
    [SerializeField] GameObject gameoverText;
    [SerializeField] GameObject Retry;
    [SerializeField] GameObject Exit;
    public float jumpPower = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameoverText.SetActive(false);
        Retry.SetActive(false);
        Exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButton("Jump"))//Input.GetButton뒤에Down(누르는 순간), Up(눌렀다 떼는 순간), Dowm이나 Up이 없을 때(누르고 있는 동안)
        //if (Input.GetMouseButtonDown(1)) //0(왼쪽 마우스), 1(오른쪽 마우스), 2(마우스 휠)
        if (Input.GetKeyDown("space"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpPower, 0);
        }
        //if (Input.GetKey(KeyCode.RightArrow))
        {
            //GetComponent<AudioSource>().Play();
            //this.transform.Translate(0.05f, 0.0f, 0.0f);
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        {
            //GetComponent<AudioSource>().Play();
            //this.transform.Translate(-0.05f, 0.0f, 0.0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Time.timeScale = 0;
        gameoverText.SetActive(true);
        Retry.SetActive(true);
        Exit.SetActive(true);
    }
}