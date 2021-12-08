using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkConcrete : JavaBlockTexture
    {
        public PinkConcrete() : base("Pink Concrete")
        {
            AddVersion("pink_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcretePink>();
        }
    }
}
