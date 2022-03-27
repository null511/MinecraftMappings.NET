using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DriedKelpBlock : JavaBlockModel
    {
        public DriedKelpBlock() : base("Dried Kelp Block")
        {
            AddVersion("dried_kelp_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("up", "block/dried_kelp_top")
                .AddTexture("down", "block/dried_kelp_bottom")
                .AddTexture("north", "block/dried_kelp_side")
                .AddTexture("south", "block/dried_kelp_side")
                .AddTexture("west", "block/dried_kelp_side")
                .AddTexture("east", "block/dried_kelp_side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#up");
                    element.FaceDown = new ModelFace("#down");
                    element.FaceNorth = new ModelFace("#north");
                    element.FaceSouth = new ModelFace("#south") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                    element.FaceWest = new ModelFace("#west");
                    element.FaceEast = new ModelFace("#east") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                });
        }
    }
}
