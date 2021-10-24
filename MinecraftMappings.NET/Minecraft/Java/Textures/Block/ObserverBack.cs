using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverBack : JavaBlockTexture
    {
        public ObserverBack() : base("Observer Back")
        {
            AddVersion("observer_back")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.Observer>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ObserverBack>();
        }
    }
}
