/***
 * Created By: Kangjie Ouyang
 * Date Created: 2/6/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: Basket function
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //using the UI libraries

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;


    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition; //get current screen position of the mouse from the Input
        mousePos2D.z = -Camera.main.transform.position.z; //the camera's z position sets how far to push the mouse into 3D
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); //convert the point from 2D screen space into 3D game world space
        Vector3 pos = this.transform.position; //move the x position of this basket to the x position of the Mouse
        pos.x = mousePos3D.x; 
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") 
        {
            Destroy(collidedWith);
        }

        int score = int.Parse(scoreGT.text);
        score += 100;
        scoreGT.text = score.ToString();

        if (score > HighScore.score) 
        {
            HighScore.score = score;
        }


    }
}
