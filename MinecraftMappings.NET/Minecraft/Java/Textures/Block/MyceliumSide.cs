using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MyceliumSide : JavaBlockTexture
    {
        public MyceliumSide() : base("Mycelium Side")
        {
            AddVersion("mycelium_side")
                .WithDefaultModel<Java.Models.Block.Mycelium>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MyceliumSide>();
        }
    }
}
