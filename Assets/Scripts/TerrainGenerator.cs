using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int depth = 20;
    public int width = 128;
    public int height = 256;
    public float scale = 5f;
    public float offsetX = 100f;
    public float offSetY = 100f;

    public float r_offsetX = 100f;
    public float r_offSetY = 100f;

    Terrain t;

    void Start() {

        t = GetComponent<Terrain>();
        offsetX = Random.Range(0f, 9999f);
        offSetY = Random.Range(0f, 9999f);
    }

    void Update(){

        t.terrainData = GenerateTerrain(t.terrainData);
        offsetX += Time.deltaTime * 5f;
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {

        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);

        terrainData.SetHeights(0,0,GenerateHeights());

        return terrainData;
    }

    float [,] GenerateHeights()
    {
        float[,] heights = new float [width, height];
        for (int i = 0; i < width; i++){
            for (int j = 0; j < height;j++)
            {   
                heights[i, j] = CalculateHeight(i, j);// some noise value         
            }
        }
        return heights;
    }

    float CalculateHeight(int x, int y){
        float xCord = (float)x/width*scale + offsetX;
        float yCord = (float)y/width*scale;
        return Mathf.PerlinNoise(xCord, yCord); 
    }
}
