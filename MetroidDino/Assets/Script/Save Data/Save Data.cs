using System;
using System.Collections.Generic;

[Serializable]
public class SaveData
{
    public float playerPositionX;
    public float playerPositionY;
    public int Scene;
    public int playerHealth;
    public int lastChekPoint;
    public List<string> collectedItems;

    public SaveData()
    {
        collectedItems = new List<string>();
    }
}
