using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeConcrete : JavaBlockTexture
    {
        public LimeConcrete() : base("Lime Concrete")
        {
            AddVersion("lime_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteLime>();
        }
    }
}
