/***
 * Created By: Kangjie Ouyang
 * Date Created: 1/31/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: Apple Despawn Logic
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY) 
        {
            Destroy(this.gameObject);
        }


    }
}
