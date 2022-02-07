/***
 * Created By: Kangjie Ouyang
 * Date Created: 2/7/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: high score manager for apple picker
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //import UI

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }

        PlayerPrefs.SetInt("HighScore", score);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

    }
}
