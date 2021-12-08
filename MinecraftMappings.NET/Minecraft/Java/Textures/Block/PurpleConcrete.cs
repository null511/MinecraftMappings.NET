using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleConcrete : JavaBlockTexture
    {
        public PurpleConcrete() : base("Purple Concrete")
        {
            AddVersion("purple_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePurple>();
        }
    }
}
