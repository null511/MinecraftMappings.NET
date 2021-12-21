using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonDoorTop : JavaBlockModel
    {
        public CrimsonDoorTop() : base("Crimson Door, Top")
        {
            AddVersion("crimson_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/crimson_door_top")
                .AddTexture("bottom", "block/crimson_door_bottom");
        }
    }
}
