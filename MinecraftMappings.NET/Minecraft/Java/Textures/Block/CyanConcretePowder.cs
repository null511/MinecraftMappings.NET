using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanConcretePowder : JavaBlockTexture
    {
        public CyanConcretePowder() : base("Cyan Concrete Powder")
        {
            AddVersion("cyan_concrete_powder")
                .WithMinVersion(new GameVersion(1, 12));
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderCyan>();
        }
    }
}
