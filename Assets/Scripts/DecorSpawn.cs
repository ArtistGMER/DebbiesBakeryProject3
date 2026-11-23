
using System.Collections.Generic;
using UnityEngine;

public class DecorSpawn : MonoBehaviour
{
    public List<GameObject> FoodItemList;
    public GameObject spawnPrefab;
   
    private Vector3 mousePos;
    private Vector3 startPos;
    private Camera Camera;
    private bool ClickedOn;
    public GameObject DecorSpawned;
    public DraggingFood Item;

    void Start()
    {
        startPos = transform.position;
        Camera = Camera.main;
    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown()
    {

        ClickedOn = true;
        //if (DecorSpawned == null)
        {
            DecorSpawned = Instantiate(Item.FoodIAm, startPos, Quaternion.identity);
        }
    }

    private void OnMouseDrag()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePos);
        pos.z = 0;
        DecorSpawned.transform.position = pos;
        ClickedOn = true;

      


    }
    
    void Update()
    {
        if (ClickedOn)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            //transform.position = Camera.ScreenToWorldPoint(mousePos);
        }
    }
}
