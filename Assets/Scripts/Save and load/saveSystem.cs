
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class saveSystem 
{

    public static void saveScore(ScoreManager player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.score";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.score";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("no file");
            return null;
        }
    }
}
