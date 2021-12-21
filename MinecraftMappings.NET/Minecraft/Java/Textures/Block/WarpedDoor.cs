using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedDoor : JavaBlockTexture
    {
        public WarpedDoor() : base("Warped Door")
        {
            AddVersion("warped_door")
                .WithDefaultModel<Java.Models.Block.WarpedDoor>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedDoor>();
        }
    }
}
