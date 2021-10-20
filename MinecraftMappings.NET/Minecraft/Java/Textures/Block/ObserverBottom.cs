using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverBottom : JavaBlockTexture
    {
        public ObserverBottom() : base("Observer Bottom")
        {
            AddVersion("observer_bottom")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.Observer>();
                //.MapsToBedrockBlock<BedrockBlocks.ObserverSide>();
        }
    }
}
