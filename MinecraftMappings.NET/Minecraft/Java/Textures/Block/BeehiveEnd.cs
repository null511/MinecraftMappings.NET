using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveEnd : JavaBlockTexture
    {
        public BeehiveEnd() : base("Beehive End")
        {
            AddVersion("beehive_end")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeehiveTop>();
        }
    }
}
