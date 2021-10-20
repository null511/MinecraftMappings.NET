using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueConcretePowder : JavaBlockTexture
    {
        public BlueConcretePowder() : base("Blue Concrete Powder")
        {
            AddVersion("blue_concrete_powder")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderBlue>();
        }
    }
}
