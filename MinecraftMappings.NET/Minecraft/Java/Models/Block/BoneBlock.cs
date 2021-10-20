using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BoneBlock : JavaBlockModel
    {
        public BoneBlock() : base("Bone Block")
        {
            AddVersion("bone_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/bone_block_top")
                .AddTexture("side", "block/bone_block_side");
        }
    }
}
