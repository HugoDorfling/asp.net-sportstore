using static Newtonsoft.Json.JsonConvert;

namespace sportstore
{
    public class Thing
    {
        public int Get(int left, int right) =>
            DeserializeObject<int>($"{left + right}");
    }
}