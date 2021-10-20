using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveFrontHoney : JavaBlockTexture
    {
        public BeehiveFrontHoney() : base("Beehive Front, Honey")
        {
            AddVersion("beehive_front_honey")
                .WithDefaultModel<Java.Models.Block.BeehiveHoney>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeehiveFrontHoney>();
        }
    }
}
