using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChippedAnvil : JavaBlockModel
    {
        public ChippedAnvil() : base("Chipped Anvil")
        {
            AddVersion("chipped_anvil", "1.4.2")
                .WithPath("models/block")
                .WithParent("block/template_anvil")
                .AddTexture("top", "block/chipped_anvil_top");
        }
    }
}
