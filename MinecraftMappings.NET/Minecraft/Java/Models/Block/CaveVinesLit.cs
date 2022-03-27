using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CaveVinesLit : JavaBlockModel
    {
        public CaveVinesLit() : base("Cave Vines Lit")
        {
            AddVersion("cave_vines_lit", "1.5")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/cave_vines_lit");
        }
    }
}
