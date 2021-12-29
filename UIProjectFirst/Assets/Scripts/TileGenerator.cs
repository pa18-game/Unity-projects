using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TileGenerator : MonoBehaviour
{
    public BackGround back;
    public GameObject Tile;
    public Transform TileHolder;
    public int hight;
    public int width;
    public InputField Numbers;
    public int column, row;
    public List<GameObject> allTiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        back = FindObjectOfType<BackGround>();
        OnStartGame();

    }
    
    void OnStartGame()
    {
        int temp = 0;
        for (int i = 0; i < back.TotalNubmers; i++)
        {
            temp++;
            GameObject gen = Instantiate(Tile, TileHolder);
            gen.GetComponent<Button>().onClick.AddListener(() => onTileClick(gen));
            gen.GetComponentInChildren<Text>().text = temp.ToString();
            gen.GetComponentInChildren<Text>().enabled = false;
            gen.GetComponent<Tiles>().index = i;
            gen.name = "tile";

            allTiles.Add(gen);
        }
        loadCollider();
    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene("UISemple");
    }
    private void loadCollider()
    {
        for (int i = 0; i < back.TotalNubmers; i++)
        {
            allTiles[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void onTileClick(GameObject Gen)
    {
        Gen.GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        Gen.GetComponentInChildren<Text>().enabled = true;

        foreach (var K in Gen.GetComponent<Tiles>().tile)
        {
            K.GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            K.GetComponentInChildren<Text>().enabled = true;
        }
    }

    



}
