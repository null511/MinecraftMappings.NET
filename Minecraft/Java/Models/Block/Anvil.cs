using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Anvil : JavaModelData
    {
        public Anvil() : base("Anvil")
        {
            AddVersion("anvil", "1.4.2")
                .WithPath("models/block")
                .WithParent("block/template_anvil")
                .AddTexture("top", "block/anvil_top");
        }
    }
}
