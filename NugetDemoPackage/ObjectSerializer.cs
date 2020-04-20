using Newtonsoft.Json;

namespace NugetDemoPackage {
    public static class ObjectSerializer {
        public static string Serialize<T>(T objectToSerialize) where T: class {
            return JsonConvert.SerializeObject(objectToSerialize);
        }
    }
}
