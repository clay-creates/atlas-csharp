using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JSONStorage
{
    public Dictionary<string, object> objects = new Dictionary<string, object>();

    public Dictionary<string, object> All()
    {
        return objects;
    }

    public void New(object obj)
    {
        var key = $"{obj.GetType().Name}.{obj.Id}";
        objects.Add(key, obj);
    }

    public void Save()
    {
        var options = new JsonSerializerOptions { WriteIndented = True };
        string filename = "../storage/inventory_manager.json";
        string json = JsonConvert.Serialize(objects, options);
        filename.WriteAllText(filename, json);
    }

    public void Load()
    {
        string filename = "../storage/inventory_manager.json";
        string json = filename.ReadAllText(filename);
        objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
    }
}