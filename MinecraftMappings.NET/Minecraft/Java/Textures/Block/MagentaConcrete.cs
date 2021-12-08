using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaConcrete : JavaBlockTexture
    {
        public MagentaConcrete() : base("Magenta Concrete")
        {
            AddVersion("magenta_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteMagenta>();
        }
    }
}
