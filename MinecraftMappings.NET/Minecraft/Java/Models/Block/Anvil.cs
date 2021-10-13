using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Anvil : JavaBlockModel
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
