using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EndStone : JavaBlockTexture
    {
        public EndStone() : base("End Stone")
        {
            AddVersion("end_stone")
                .WithDefaultModel<Java.Models.Block.EndStone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EndStone>();
        }
    }
}
