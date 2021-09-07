using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private KeyCode key_1;
    [SerializeField] private KeyCode key_2;
    [SerializeField] private Vector3 moveDirection;

    private void FixedUpdate()
    {
        if(Input.GetKey(key_1))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        else if (Input.GetKey(key_2))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        /*if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene(0);
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player")&&other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (this.CompareTag("Cube") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(11);
        }
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach(ActivateCubes button in FindObjectsOfType<ActivateCubes>())
            {
                button.canPush = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (ActivateCubes button in FindObjectsOfType<ActivateCubes>())
            {
                button.canPush = true;
            }
        }
    }
}
