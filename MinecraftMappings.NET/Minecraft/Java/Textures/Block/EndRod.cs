using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EndRod : JavaBlockTexture
    {
        public EndRod() : base("End Rod")
        {
            AddVersion("end_rod")
                .WithDefaultModel<Java.Models.Block.EndRod>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EndRod>();
        }
    }
}
