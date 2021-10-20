using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownMushroomBlock : JavaBlockModel
    {
        public BrownMushroomBlock() : base("Brown Mushroom Block")
        {
            AddVersion("brown_mushroom_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_single_face")
                .AddTexture("texture", "block/brown_mushroom_block");
        }
    }
}
