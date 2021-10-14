using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceDoorTop : JavaBlockModel
    {
        public SpruceDoorTop() : base("Spruce Door, Top")
        {
            AddVersion("spruce_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/spruce_door_top")
                .AddTexture("bottom", "block/spruce_door_bottom");
        }
    }
}
