using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumManager : Singleton<AlbumManager>
{
    public List<bool> unlock;
    public List<string> explanation;
    public List<Sprite> image;
    public GameObject albumContainer;

    JsonSave saveData = new JsonSave();

    string dataPath;
    string saveKey = "SaveData";

    void Start()
    {
        ContainerOff();
        dataPath = Application.persistentDataPath + "./SaveData.json";
        Load();
        Save();
    }

    void Update()
    {

    }

    void Save()
    {
        saveData.explanation = explanation;
        saveData.unlock = unlock;

        string jsonSave = JsonUtility.ToJson(saveData, true);

        System.IO.File.WriteAllText(dataPath, jsonSave);/*
        PlayerPrefs.SetString(saveKey, jsonSave);*/
    }

    void Load()
    {
        string jsonSave = "";
        if (System.IO.File.Exists(dataPath))
            jsonSave = System.IO.File.ReadAllText(dataPath);
/*
        jsonSave = PlayerPrefs.GetString(saveKey);*/

        saveData = JsonUtility.FromJson<JsonSave>(jsonSave);
        unlock = saveData.unlock;
        explanation = saveData.explanation;
    }

    public void ContainerOff()
    {
        albumContainer.SetActive(false);
    }

    public void ContainerOn()
    {
        albumContainer.SetActive(true);
    }
}

[System.Serializable]
public class JsonSave
{
    public List<bool> unlock;
    public List<string> explanation;
}