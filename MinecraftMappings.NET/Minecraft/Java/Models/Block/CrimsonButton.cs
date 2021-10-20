using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonButton : JavaBlockModel
    {
        public CrimsonButton() : base("Crimson Button")
        {
            AddVersion("crimson_button", "1.16")
                .WithPath("models/block")
                .WithParent("block/button")
                .AddTexture("texture", "block/crimson_planks");
        }
    }
}
