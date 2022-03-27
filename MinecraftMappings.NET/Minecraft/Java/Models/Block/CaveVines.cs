using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CaveVines : JavaBlockModel
    {
        public CaveVines() : base("Cave Vines")
        {
            AddVersion("cave_vines", "1.5")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/cave_vines");
        }
    }
}
