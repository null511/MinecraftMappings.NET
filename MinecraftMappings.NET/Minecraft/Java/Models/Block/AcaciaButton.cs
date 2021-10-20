using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaButton : JavaBlockModel
    {
        public AcaciaButton() : base("Acacia Button")
        {
            AddVersion("acacia_button", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/button")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
