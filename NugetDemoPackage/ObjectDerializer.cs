using Newtonsoft.Json;

namespace NugetDemoPackage {
    public static class ObjectDerializer {
        public static T Deserialize<T>(string jsonObjectString) {
            return JsonConvert.DeserializeObject<T>(jsonObjectString);
        }
    }
}
