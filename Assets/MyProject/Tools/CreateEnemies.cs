using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CreateEnemies : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject endui;

    GameObject e1;
    GameObject e2;
    GameObject e3;
    void Start()
    {
        e1 = Instantiate(enemy1, new Vector3(0, 1f, 15f), new Quaternion(0, 180, 0, 0));
        e2 = Instantiate(enemy2, new Vector3(-16f, 8.5f, 16f), new Quaternion(0, 0, 0, 0));
        e3 = Instantiate(enemy3, new Vector3(15f, 3f, 11f), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (e1 == null && e2 == null && e3 == null)
        {
            endui.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
