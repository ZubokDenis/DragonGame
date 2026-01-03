using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSave : MonoBehaviour
{
    private const string health_key = "Player_Health";
    private const string pos_x_key = "Player_Pox_X";
    private const string pos_y_key = "Player_Pox_Y";
    private const string scene_key = "Current_Scene";

    public static SimpleSave Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePosition(Vector2 position)
    {
        PlayerPrefs.SetFloat("Player_Pox_X", position.x);
        PlayerPrefs.SetFloat("Player_Pox_Y", position.y);
        PlayerPrefs.Save();

    }
    public void SaveHealth(float health)
    {
        PlayerPrefs.SetFloat("Player_Health", health);
        PlayerPrefs.Save();
    }
    public void SaveScene(string scene)
    {
        PlayerPrefs.SetString("Current_Scene", scene);
        PlayerPrefs.Save();
    }
    
}
