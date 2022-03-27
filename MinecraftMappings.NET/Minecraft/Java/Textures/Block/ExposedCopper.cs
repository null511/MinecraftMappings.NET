using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ExposedCopper : JavaBlockTexture
    {
        public ExposedCopper() : base("Exposed Copper")
        {
            AddVersion("exposed_copper")
                .WithDefaultModel<Java.Models.Block.ExposedCopper>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ExposedCopper>();
        }
    }
}
