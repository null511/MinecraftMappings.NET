using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchDoorTop : JavaModelData
    {
        public BirchDoorTop() : base("Birch Door, Top")
        {
            AddVersion("birch_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/birch_door_top")
                .AddTexture("bottom", "block/birch_door_bottom");
        }
    }
}
