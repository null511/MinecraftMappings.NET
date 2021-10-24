using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceSapling : JavaBlockTexture
    {
        public SpruceSapling() : base("Spruce Sapling")
        {
            AddVersion("spruce_sapling")
                .WithDefaultModel<Java.Models.Block.SpruceSapling>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SpruceSapling>();
        }
    }
}
