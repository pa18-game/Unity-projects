using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    public int column;
    public int row;
    public TileGenerator TileGenerator;
    public int index;
    public List<Tiles> tile = new List<Tiles>();
    // Start is called before the first frame update
    void Start()
    {
        TileGenerator = FindObjectOfType<TileGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isStart;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "tile")
        {
            foreach(var a in tile)
            {
                if(a == collision.gameObject.GetComponent<Tiles>())
                {
                    return;
                }
            }

            tile.Add(collision.gameObject.GetComponent<Tiles>());
        }
       
    }
    
    

}
