using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Block : JavaBlockModel
    {
        public Block() : base("Block")
        {
            AddVersion("block", "1.0.0")
                .WithPath("models/block");
        }
    }
}
