using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteWallPost : JavaBlockModel
    {
        public AndesiteWallPost() : base("Andesite Wall Post")
        {
            AddVersion("andesite_wall_post", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_wall_post")
                .AddTexture("wall", "block/andesite");
        }
    }
}
