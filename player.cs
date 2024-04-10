using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed;
    public Rigidbody maze;
    public GameObject uga;



    // Start is called before the first frame update
    void Start()
    {
        maze = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            maze.AddForce(Vector3.forward * speed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maze.AddForce(Vector3.back * speed);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            maze.AddForce(Vector3.right * speed);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            maze.AddForce(Vector3.left * speed);
        }

    }
    public int collectedcoins = 0;
    public void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.name == "coin")
        {
            Destroy(other.gameObject);
            collectedcoins++;
            if (collectedcoins >=6 )
            {
                uga.SetActive(true);
            }

        }
    }

    public void ReStartGame()
    {
        SceneManager.LoadScene(0);
    }
}
