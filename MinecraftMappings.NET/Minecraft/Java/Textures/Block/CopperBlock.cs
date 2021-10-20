using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CopperBlock : JavaBlockTexture
    {
        public CopperBlock() : base("Copper Block")
        {
            AddVersion("copper_block")
                .WithDefaultModel<Java.Models.Block.CopperBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CopperBlock>();
        }
    }
}
