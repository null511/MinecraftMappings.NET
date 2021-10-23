using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TripwireHook : JavaBlockModel
    {
        public TripwireHook() : base("Tripwire Hook")
        {
            AddVersion("tripwire_hook", "1.0.0")
                .WithPath("models/block")
                .AddTexture("hook", "block/tripwire_hook")
                .AddTexture("wood", "block/oak_planks")
                .AddElement(element => {
                    element.From = new Vector3(6.2f, 3.8f, 7.9f);
                    element.To = new Vector3(9.8f, 4.6f, 11.5f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 5.2f),
                        Axis = ModelAxis.X,
                        Angle = -45,
                    };
                    element.FaceUp = new ModelFace("#hook") {
                        UV = UVMap(5f, 3f, 11f, 9f),
                    };
                    element.FaceDown = new ModelFace("#hook") {
                        UV = UVMap(5f, 3f, 11f, 9f),
                    };
                    element.FaceNorth = new ModelFace("#hook") {
                        UV = UVMap(5f, 3f, 11f, 4f),
                    };
                    element.FaceSouth = new ModelFace("#hook") {
                        UV = UVMap(5f, 8f, 11f, 9f),
                    };
                    element.FaceWest = new ModelFace("#hook") {
                        UV = UVMap(5f, 8f, 11f, 9f),
                    };
                    element.FaceEast = new ModelFace("#hook") {
                        UV = UVMap(5f, 3f, 11f, 4f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.4f, 3.8f, 10.3f);
                    element.To = new Vector3(8.6f, 4.6f, 10.3f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 5.2f),
                        Axis = ModelAxis.X,
                        Angle = -45,
                    };
                    element.FaceNorth = new ModelFace("#hook") {
                        UV = UVMap(7f, 8f, 9f, 9f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.4f, 3.8f, 9.1f);
                    element.To = new Vector3(8.6f, 4.6f, 9.1f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 5.2f),
                        Axis = ModelAxis.X,
                        Angle = -45,
                    };
                    element.FaceSouth = new ModelFace("#hook") {
                        UV = UVMap(7f, 3f, 9f, 4f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.4f, 3.8f, 9.1f);
                    element.To = new Vector3(7.4f, 4.6f, 10.3f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 5.2f),
                        Axis = ModelAxis.X,
                        Angle = -45,
                    };
                    element.FaceEast = new ModelFace("#hook") {
                        UV = UVMap(7f, 8f, 9f, 9f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8.6f, 3.8f, 9.1f);
                    element.To = new Vector3(8.6f, 4.6f, 10.3f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 5.2f),
                        Axis = ModelAxis.X,
                        Angle = -45,
                    };
                    element.FaceWest = new ModelFace("#hook") {
                        UV = UVMap(7f, 3f, 9f, 4f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.4f, 5.2f, 10f);
                    element.To = new Vector3(8.8f, 6.8f, 14f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 14f),
                        Axis = ModelAxis.X,
                        Angle = 45,
                    };
                    element.FaceUp = new ModelFace("#wood") {
                        UV = UVMap(7f, 2f, 9f, 7f),
                    };
                    element.FaceDown = new ModelFace("#wood") {
                        UV = UVMap(7f, 9f, 9f, 14f),
                    };
                    element.FaceNorth = new ModelFace("#wood") {
                        UV = UVMap(7f, 9f, 9f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#wood") {
                        UV = UVMap(7f, 9f, 9f, 11f),
                    };
                    element.FaceWest = new ModelFace("#wood") {
                        UV = UVMap(2f, 9f, 7f, 11f),
                    };
                    element.FaceEast = new ModelFace("#wood") {
                        UV = UVMap(9f, 9f, 14f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 1f, 14f);
                    element.To = new Vector3(10f, 9f, 16f);
                    element.FaceUp = new ModelFace("#wood") {
                        UV = UVMap(6f, 0f, 10f, 2f),
                    };
                    element.FaceDown = new ModelFace("#wood") {
                        UV = UVMap(6f, 14f, 10f, 16f),
                    };
                    element.FaceNorth = new ModelFace("#wood") {
                        UV = UVMap(6f, 7f, 10f, 15f),
                    };
                    element.FaceSouth = new ModelFace("#wood") {
                        UV = UVMap(6f, 7f, 10f, 15f),
                    };
                    element.FaceWest = new ModelFace("#wood") {
                        UV = UVMap(0f, 7f, 2f, 15f),
                    };
                    element.FaceEast = new ModelFace("#wood") {
                        UV = UVMap(14f, 7f, 16f, 15f),
                    };
                });
        }
    }
}
