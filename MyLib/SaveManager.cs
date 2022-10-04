using System.Text.Json;
using System.Xml;

namespace MyLib;

public static class SaveManager
{
    public static void Save(Object myObject)
    {
        string monObjetEnString = JsonSerializer.Serialize(myObject);
        File.WriteAllText(Environment.CurrentDirectory + "/save.jpeg", monObjetEnString);
    }

    public static T? Load<T>()
    {
        var monJson = File.ReadAllText(Environment.CurrentDirectory + "/save.jpeg");
        var myObject = JsonSerializer.Deserialize<T>(monJson);
        return myObject;
    }   
}