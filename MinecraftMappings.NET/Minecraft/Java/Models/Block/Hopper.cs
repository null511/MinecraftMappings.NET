using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Hopper : JavaBlockModel
    {
        public Hopper() : base("Hopper")
        {
            AddVersion("hopper", "1.0.0")
                .WithPath("models/block")
                .AddTexture("top", "block/hopper_top")
                .AddTexture("side", "block/hopper_outside")
                .AddTexture("inside", "block/hopper_inside")
                .AddElement(element => {
                    element.From = new Vector3(0f, 10f, 0f);
                    element.To = new Vector3(16f, 11f, 16f);
                    element.FaceUp = new ModelFace("#inside");
                    element.FaceDown = new ModelFace("#side");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 11f, 0f);
                    element.To = new Vector3(2f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 11f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 11f, 0f);
                    element.To = new Vector3(14f, 16f, 2f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 11f, 14f);
                    element.To = new Vector3(14f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 4f, 4f);
                    element.To = new Vector3(12f, 10f, 12f);
                    element.FaceDown = new ModelFace("#side");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 6f);
                    element.To = new Vector3(10f, 4f, 10f);
                    element.FaceDown = new ModelFace("#side");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                });
        }
    }
}
