using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class protogen : MonoBehaviour
{

    public Transform transformPlayer;

    public Vector3Int size = new Vector3Int(50, 50, 0);
    public int seed;
    [Range(0, 1)] public float perGrass;
    public Tilemap tilemap;
    public HexagonalRuleTile grass;
    public Tile dirt;
    public Vector3 oldPos = new Vector3(0,0,0);
    
    // Start is called before the first frame update
    void Start()
    {
        for(int x=-size.x; x < size.x; x++) {
            for(int y = -size.y; y < size.y; y++) {
                genTile(tilemap, grass, dirt, new Vector3Int(x, y, 0), seed, perGrass);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(oldPos.x - transformPlayer.position.x > 1 || oldPos.y - transformPlayer.position.y > 1 || oldPos.x - transformPlayer.position.x < -1 || oldPos.y - transformPlayer.position.y < -1) {

            for(int x = -size.x; x < size.x; x++) {
                for(int y = -size.y; y < size.y; y++) {

                    if(tilemap.GetTile(new Vector3Int(x + (int)(transformPlayer.position.x / 0.8659766), y + (int)(transformPlayer.position.y/0.75), 0)) == null)

                    genTile(tilemap, grass, dirt, new Vector3Int(x + (int)(transformPlayer.position.x / 0.8659766), y + (int)(transformPlayer.position.y /0.75), 0), seed, perGrass);
                }
            }

            oldPos = transformPlayer.position;

        }
    }

    private void genTile(Tilemap tm, HexagonalRuleTile grass, Tile dirt, Vector3Int pos, int seed, float perG) {

        bool t = Random.Range(0f, 1f) < perG ? true : false;
        if(t){
            tm.SetTile(pos, grass);
        }
        else {
            tm.SetTile(pos, dirt);
        }
        
    }
}
