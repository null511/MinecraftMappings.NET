using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveFront : JavaBlockTexture
    {
        public BeehiveFront() : base("Beehive Front")
        {
            AddVersion("beehive_front")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeehiveFront>();
        }
    }
}
