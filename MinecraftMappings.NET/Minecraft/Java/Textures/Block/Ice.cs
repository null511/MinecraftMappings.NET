using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Ice : JavaBlockTexture
    {
        public Ice() : base("Ice")
        {
            AddVersion("ice")
                .WithDefaultModel<Java.Models.Block.Ice>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Ice>();
        }
    }
}
