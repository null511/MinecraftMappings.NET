using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChorusPlant : JavaBlockTexture
    {
        public ChorusPlant() : base("Chorus Plant")
        {
            AddVersion("chorus_plant")
                .WithDefaultModel<Java.Models.Block.ChorusPlant>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChorusFlower>();
        }
    }
}
