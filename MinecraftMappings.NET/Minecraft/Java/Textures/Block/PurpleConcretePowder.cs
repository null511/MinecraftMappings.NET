using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleConcretePowder : JavaBlockTexture
    {
        public PurpleConcretePowder() : base("Purple Concrete Powder")
        {
            AddVersion("purple_concrete_powder")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePowderPurple>();
        }
    }
}
