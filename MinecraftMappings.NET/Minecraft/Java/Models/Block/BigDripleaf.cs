using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BigDripleaf : JavaBlockModel
    {
        public BigDripleaf() : base("Big Dripleaf")
        {
            AddVersion("big_dripleaf", "1.17")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/big_dripleaf_top")
                .AddTexture("side", "block/big_dripleaf_side")
                .AddTexture("tip", "block/big_dripleaf_tip")
                .AddTexture("stem", "block/big_dripleaf_stem")
                .AddElement(element => {
                    element.From = new Vector3(0f, 15f, 0f);
                    element.To = new Vector3(16f, 15f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#top", UVMap(0f, 16f, 16f, 0f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 11f, 0f);
                    element.To = new Vector3(16f, 15f, 0.002f);
                    element.FaceNorth = new ModelFace("#tip", UVMap(0f, 0f, 16f, 4f));
                    element.FaceSouth = new ModelFace("#tip", UVMap(16f, 0f, 0f, 4f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 11f, 0f);
                    element.To = new Vector3(0.002f, 15f, 16f);
                    element.FaceWest = new ModelFace("#side", UVMap(0f, 0f, 16f, 4f));
                    element.FaceEast = new ModelFace("#side", UVMap(16f, 0f, 0f, 4f));
                })
                .AddElement(element => {
                    element.From = new Vector3(15.998f, 11f, 0f);
                    element.To = new Vector3(16f, 15f, 16f);
                    element.FaceWest = new ModelFace("#side", UVMap(0f, 0f, 16f, 4f));
                    element.FaceEast = new ModelFace("#side", UVMap(16f, 0f, 0f, 4f));
                })
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 12f);
                    element.To = new Vector3(11f, 15f, 12f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 12f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#stem", UVMap(3f, 0f, 14f, 16f));
                    element.FaceSouth = new ModelFace("#stem", UVMap(3f, 0f, 14f, 16f));
                })
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 12f);
                    element.To = new Vector3(11f, 15f, 12f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 12f),
                        Axis = ModelAxis.Y,
                        Angle = -45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#stem", UVMap(3f, 0f, 14f, 16f));
                    element.FaceSouth = new ModelFace("#stem", UVMap(3f, 0f, 14f, 16f));
                });
        }
    }
}
