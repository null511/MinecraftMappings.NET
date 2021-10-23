using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PackedIce : JavaBlockModel
    {
        public PackedIce() : base("Packed Ice")
        {
            AddVersion("packed_ice", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/packed_ice");
        }
    }
}
