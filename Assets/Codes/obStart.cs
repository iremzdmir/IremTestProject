using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveGame();
    }

    
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {

            LoadGame();

        }
    }
    public void SaveGame()
    {
        PlayerPrefs.SetFloat("X Axis", transform.position.x);
        PlayerPrefs.SetFloat("Y Axis", transform.position.y);
        PlayerPrefs.SetFloat("Z Axis", transform.position.z);
    }

    public void LoadGame()
    {
        float X = PlayerPrefs.GetFloat("X Axis");
        float Y = PlayerPrefs.GetFloat("Y Axis");
        float Z = PlayerPrefs.GetFloat("Z Axis");

        transform.position = new Vector3(X, Y, Z);
    }
}
