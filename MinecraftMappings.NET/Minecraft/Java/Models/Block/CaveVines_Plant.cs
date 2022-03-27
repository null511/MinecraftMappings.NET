using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CaveVines_Plant : JavaBlockModel
    {
        public CaveVines_Plant() : base("Cave Vines, Plant")
        {
            AddVersion("cave_vines_plant", "1.5")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/cave_vines_plant");
        }
    }
}
