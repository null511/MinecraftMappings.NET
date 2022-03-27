using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EndStoneBricks : JavaBlockTexture
    {
        public EndStoneBricks() : base("End Stone Bricks")
        {
            AddVersion("end_stone_bricks")
                .WithDefaultModel<Java.Models.Block.EndStoneBricks>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EndStoneBricks>();
        }
    }
}
