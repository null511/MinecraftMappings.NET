using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Grass : JavaBlockTexture
    {
        public Grass() : base("Grass")
        {
            AddVersion("grass")
                .WithDefaultModel<Java.Models.Block.Grass>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Tallgrass>();
        }
    }
}
