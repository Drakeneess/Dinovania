using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    private static string savePath = Application.persistentDataPath + "/game.save";

    public static void SaveGame(SaveData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(savePath, FileMode.Create);

        try
        {
            formatter.Serialize(stream, data);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error saving file: " + e.Message);
        }
        finally
        {
            stream.Close();
        }
    }

    public static SaveData LoadGame()
    {
        if (File.Exists(savePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(savePath, FileMode.Open);

            try
            {
                SaveData data = formatter.Deserialize(stream) as SaveData;
                return data;
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error loading file: " + e.Message);
                return null;
            }
            finally
            {
                stream.Close();
            }
        }
        else
        {
            Debug.LogWarning("Save file not found, creating new save file...");
            SaveData newData = new SaveData();
            SaveGame(newData); // Guarda un nuevo archivo vacío
            return newData;
        }
    }
}
