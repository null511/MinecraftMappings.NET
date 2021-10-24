using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class KelpPlant : JavaBlockTexture
    {
        public KelpPlant() : base("Kelp Plant")
        {
            AddVersion("kelp_plant")
                .WithDefaultModel<Java.Models.Block.KelpPlant>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.KelpA>();
        }
    }
}
