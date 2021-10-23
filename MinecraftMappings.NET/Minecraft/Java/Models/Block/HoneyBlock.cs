using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class HoneyBlock : JavaBlockModel
    {
        public HoneyBlock() : base("Honey Block")
        {
            AddVersion("honey_block", "1.15")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("up", "block/honey_block_top")
                .AddTexture("down", "block/honey_block_bottom")
                .AddTexture("side", "block/honey_block_side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#down");
                    element.FaceDown = new ModelFace("#down");
                    element.FaceNorth = new ModelFace("#down");
                    element.FaceSouth = new ModelFace("#down");
                    element.FaceWest = new ModelFace("#down");
                    element.FaceEast = new ModelFace("#down");
                })
                .AddElement(element => {
                    element.From = new Vector3(1f, 1f, 1f);
                    element.To = new Vector3(15f, 15f, 15f);
                    element.FaceUp = new ModelFace("#up") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceDown = new ModelFace("#down") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceNorth = new ModelFace("#side") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceSouth = new ModelFace("#side") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                });
        }
    }
}
