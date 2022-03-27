using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChorusFlower : JavaBlockTexture
    {
        public ChorusFlower() : base("Chorus Flower")
        {
            AddVersion("chorus_flower")
                .WithDefaultModel<Java.Models.Block.ChorusFlower>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChorusFlower>();
        }
    }
}
