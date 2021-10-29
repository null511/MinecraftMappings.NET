using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverBackOn : JavaBlockTexture
    {
        public ObserverBackOn() : base("Observer Back, On")
        {
            AddVersion("observer_back_on")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.ObserverOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ObserverBackLit>();
        }
    }
}
