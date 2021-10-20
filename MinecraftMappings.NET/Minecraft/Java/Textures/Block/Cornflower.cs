using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cornflower : JavaBlockTexture
    {
        public Cornflower() : base("Cornflower")
        {
            AddVersion("cornflower")
                .WithDefaultModel<Java.Models.Block.Cornflower>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerCornflower>();
        }
    }
}
