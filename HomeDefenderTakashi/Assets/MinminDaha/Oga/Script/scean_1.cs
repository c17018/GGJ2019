using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scean_1 : MonoBehaviour {

    [SerializeField] private string gameOverScene;
    public float speed = 3.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(";"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("/"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("_"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("."))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
}

