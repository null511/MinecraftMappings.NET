using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveFrontHoney : JavaBlockTexture
    {
        public BeehiveFrontHoney() : base("Beehive Front, Honey")
        {
            AddVersion(5, "beehive_front_honey")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.BeehiveHoney>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeehiveFrontHoney>();
        }
    }
}
