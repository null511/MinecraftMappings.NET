using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveSide : JavaBlockTexture
    {
        public BeehiveSide() : base("Beehive Side")
        {
            AddVersion(5, "beehive_side")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeehiveSide>();
        }
    }
}
