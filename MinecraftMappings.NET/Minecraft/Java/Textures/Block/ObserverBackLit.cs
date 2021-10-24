using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverBackLit : JavaBlockTexture
    {
        public ObserverBackLit() : base("Observer Back, Lit")
        {
            AddVersion("observer_back_lit")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.ObserverOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ObserverBackLit>();
        }
    }
}
