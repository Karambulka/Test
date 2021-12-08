using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    private CubePos nowCube = new CubePos(0, 1, 0);
    public float cubeChangePlaceSpeed = 0.5f;
    public Transform CubeToPlace;

    private List<Vector3> allCubesPositions = new List<Vector3>()
    {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(-1,0,0),
        new Vector3(0,1,0),
        new Vector3(0,0,1),
        new Vector3(0,0,-1),
        new Vector3(1,0,1),
        new Vector3(-1,0,-1),
        new Vector3(-1,0,1),
        new Vector3(1,0,-1),
    };

    private void Start()
    {
        StartCoroutine(ShowCubePlace());
    }
    IEnumerator ShowCubePlace()
    {
        while (true)
        {
            SpawnPositions();

            yield return new WaitForSeconds(cubeChangePlaceSpeed);
        }
    }

    private void SpawnPositions();

    List<Vector3> positions = new List<Vector3>();
    
    if(IsPositionEmpty(new Vector3(nowCube.x + 1, nowCube.y, nowCube.z))) 
    {
        positions.Add(nowCube.x + 1, nowCube.y, nowCube.z);     
    }

else if (IsPositionEmpty(new Vector3(nowCube.x - 1, nowCube.y, nowCube.z)))
{
    positions.Add(nowCube.x - 1, nowCube.y, nowCube.z);
}

else if (IsPositionEmpty(new Vector3(nowCube.x, nowCube.y + 1, nowCube.z)))
{
    positions.Add(nowCube.x, nowCube.y + 1, nowCube.z);
}

else if (IsPositionEmpty(new Vector3(nowCube.x, nowCube.y - 1, nowCube.z)))
{
    positions.Add(nowCube.x, nowCube.y - 1, nowCube.z);
}

else if (IsPositionEmpty(new Vector3(nowCube.x, nowCube.y, nowCube.z + 1)))
{
    positions.Add(nowCube.x, nowCube.y, nowCube.z + 1);
}

else if (IsPositionEmpty(new Vector3(nowCube.x, nowCube.y, nowCube.z-1)))
{
    positions.Add(nowCube.x, nowCube.y, nowCube.z - 1);
}



private bool IsPositionEmpty(Vector3 targetpos)
    {
    if (pos.y == 0)
        return false;

    foreach (Vector3 pos in AllCubesPositions)
    {
        if(pos.x==targetpos.x && pos.y==targetpos.y && pos.z==targetpos.z)
            return false:
    }
    return true;
    }
        
}

struct CubePos
{
    public int x, y, z;

    public CubePos(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector 3 getVector()
    {
        return new Vector(x, y, z);
    }

    public void setVector(Vector3 pos)
    {
        x = Convert.ToInt32(pos.x);
        y = Convert.ToInt32(pos.y);
        z = Convert.ToInt32(pos.z);
    }
}