using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaDoor : JavaBlockModel
    {
        public AcaciaDoor() : base("Acacia Door")
        {
            AddVersion("acacia_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/acacia_door_top")
                .AddTexture("bottom", "block/acacia_door_bottom");
        }
    }
}
