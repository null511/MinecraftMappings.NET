using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeepingVinesPlant : JavaBlockModel
    {
        public WeepingVinesPlant() : base("Weeping Vines Plant")
        {
            AddVersion("weeping_vines_plant", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/weeping_vines_plant");
        }
    }
}
