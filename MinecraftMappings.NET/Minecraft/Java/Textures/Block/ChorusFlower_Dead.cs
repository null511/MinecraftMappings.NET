using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChorusFlower_Dead : JavaBlockTexture
    {
        public ChorusFlower_Dead() : base("Chorus Flower, Dead")
        {
            AddVersion("chorus_flower_dead")
                .WithDefaultModel<Java.Models.Block.ChorusFlower_Dead>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChorusFlowerDead>();
        }
    }
}
