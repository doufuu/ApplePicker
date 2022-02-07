/***
 * Created By: Kangjie Ouyang
 * Date Created: 2/6/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: Spawns the basket
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //scene management libraries

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();



        for (int i=0; i<numBaskets; i++) 
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGo in tAppleArray) 
        {
            Destroy(tGo);
        }

        int basketIndex = basketList.Count - 1;
        GameObject tBasketGo = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);

        if (basketList.Count == 0) 
        {
            SceneManager.LoadScene("Scene_00");
        }

    }

}
