using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverTop : JavaBlockTexture
    {
        public ObserverTop() : base("Observer Top")
        {
            AddVersion("observer_top")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.Observer>();
                //.MapsToBedrockBlock<BedrockBlocks.ObserverSide>();
        }
    }
}
