using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CakeSide : JavaBlockTexture
    {
        public CakeSide() : base("Cake Side")
        {
            AddVersion("cake_side")
                .WithDefaultModel<Java.Models.Block.Cake>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CakeBottom>();
        }
    }
}
