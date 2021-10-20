using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverFront : JavaBlockTexture
    {
        public ObserverFront() : base("Observer Front")
        {
            AddVersion("observer_front")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.Observer>();
                //.MapsToBedrockBlock<BedrockBlocks.ObserverSide>();
        }
    }
}
