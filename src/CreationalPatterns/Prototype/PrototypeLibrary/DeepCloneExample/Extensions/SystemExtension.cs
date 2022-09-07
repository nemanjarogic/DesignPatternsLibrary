using Newtonsoft.Json;

namespace PrototypeLibrary.DeepCloneExample.Extensions;

public static class SystemExtension
{
    public static T DeepClone<T>(this T source)
    {
        var serialized = JsonConvert.SerializeObject(source);
        var clonedObject = JsonConvert.DeserializeObject<T>(serialized);

        if (clonedObject == null)
        {
            throw new JsonException("The source can't be serialized and deserialized successfully.");
        }

        return clonedObject;
    }
}
