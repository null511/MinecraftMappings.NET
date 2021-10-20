using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Carrots_Stage0 : JavaBlockTexture
    {
        public Carrots_Stage0() : base("Carrots, Stage 0")
        {
            AddVersion("carrots_stage0")
                .WithDefaultModel<Java.Models.Block.Carrots_Stage0>();
                //.MapsToBedrockBlock<BedrockBlocks.Carrots_Stage0>();
        }
    }
}
